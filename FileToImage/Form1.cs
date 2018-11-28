using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FileToImage {
	public partial class Form1 : Form {

		public static int imageSamples = 3;

		public string selectedFile;

		public enum BlendingMode {
			Multiply,
			Overlay,
			Screen,
			LinearDodge
		};

		public Form1() {
			InitializeComponent();
			progressBar1.Visible = false;
			comboBox1.SelectedIndex = 1;
		}

		public void CreateImage(string fileName) {
			imageSamples = (int)numericUpDown1.Value;

			imageSamples *= 2;

			byte[] fileBytes = File.ReadAllBytes(fileName);
			byte[] sampleBytes = new byte[imageSamples];

			for (int i = 0; i < imageSamples; i++) {
				sampleBytes[i] = fileBytes[fileBytes.Length / imageSamples * (i + 1) - 1];
				if (sampleBytes[i] == 0) sampleBytes[i] = 255;
			}

			imageSamples /= 2;

			int imgWidth = 255, imgHeight = 255;

			Bitmap[] sampleImages = new Bitmap[imageSamples];
			progressBar1.Visible = true;
			for (int i = 0; i < sampleBytes.Length / 2; i++) {
				progressBar1.Value = 100 * (i+1) / imageSamples;
				using (WebClient wc = new WebClient()) {
					int width = sampleBytes[i * 2];
					//if (width % 2 == 1) width += 1;
					int height = sampleBytes[i * 2 + 1];
					//if (height % 2 == 1) height += 1;
					Console.WriteLine(width + "x" + height);
					byte[] imgBytes = wc.DownloadData("https://picsum.photos/" + width + "/" + height);


					using (MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length)) {
						Image img = Image.FromStream(ms);
						Bitmap bidmab = new Bitmap(img);
						Bitmap bm = new Bitmap(imgWidth, imgHeight, PixelFormat.Format24bppRgb);
						using (Graphics g = Graphics.FromImage(bm)) {
							g.DrawImage(bidmab, new Rectangle(0, 0, imgWidth, imgHeight));
						}
						bidmab.Dispose();
						sampleImages[i] = bm;
					}
				}
			}

			BlendingMode[] modes = { BlendingMode.Multiply, BlendingMode.Overlay, BlendingMode.Screen, BlendingMode.LinearDodge };
			BlendingMode mode = modes[comboBox1.SelectedIndex];

			Bitmap bmp = Blend(sampleImages[0], sampleImages[1], mode);
			for (int i = 1; i < imageSamples; i++) {
				bmp = Blend(bmp, sampleImages[i], mode);
			}

			pictureBox1.Image = bmp;

			progressBar1.Visible = false;
		}

		public static Bitmap Blend(Bitmap src, Bitmap bln, BlendingMode blendingMode) {
			BitmapData srcData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			byte[] pixelBuffer = new byte[srcData.Stride * srcData.Height];
			Marshal.Copy(srcData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
			src.UnlockBits(srcData);

			BitmapData blnData = bln.LockBits(new Rectangle(0, 0, bln.Width, bln.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			byte[] blendBuffer = new byte[blnData.Stride * blnData.Height];
			Marshal.Copy(blnData.Scan0, blendBuffer, 0, blendBuffer.Length);
			bln.UnlockBits(blnData);

			int r = 0, g = 0, b = 0;

			for (int k = 0; (k + 4 < pixelBuffer.Length) && (k + 4 < blendBuffer.Length); k += 4) {
				r = BlendingOperation(pixelBuffer[k + 2], blendBuffer[k + 2], blendingMode);
				g = BlendingOperation(pixelBuffer[k + 1], blendBuffer[k + 1], blendingMode);
				b = BlendingOperation(pixelBuffer[k + 0], blendBuffer[k + 0], blendingMode);

				if (r < 0) r = 0; else if (r > 255) r = 255;
				if (g < 0) g = 0; else if (g > 255) g = 255;
				if (b < 0) b = 0; else if (b > 255) b = 255;

				pixelBuffer[k + 2] = (byte)r;
				pixelBuffer[k + 1] = (byte)g;
				pixelBuffer[k + 0] = (byte)b;
			}

			Bitmap outputBmp = new Bitmap(src.Width, src.Height);

			BitmapData outputData = outputBmp.LockBits(new Rectangle(0, 0, outputBmp.Width, outputBmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
			Marshal.Copy(pixelBuffer, 0, outputData.Scan0, pixelBuffer.Length);
			outputBmp.UnlockBits(outputData);

			return outputBmp;
		}

		public static int BlendingOperation(int pixel, int blend, BlendingMode mode) {
			double p = (double)pixel / 255;
			double b = (double)blend / 255;

			double result = -1;

			if (mode == BlendingMode.Multiply) {
				result = p * b;
			} else if (mode == BlendingMode.Overlay) {
				result = (p > 0.5 ? 1 : 0) * (1 - (1 - 2 * (p - 0.5)) * (1 - b)) + (p <= 0.5 ? 1 : 0) * ((2 * p) * b);
			} else if (mode == BlendingMode.Screen) {
				result = 1 - (1 - p) * (1 - b);
			} else if (mode == BlendingMode.LinearDodge) {
				result = p + b;
			}

			return (int)(result * 255);
		}

		private void pictureBox1_Click(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				selectedFile = openFileDialog1.FileName;
				label5.Text = "Selected file: " + selectedFile;
			}
		}

		private void label3_Click(object sender, EventArgs e) {

		}

		private void button2_Click(object sender, EventArgs e) {
			CreateImage(selectedFile);
		}

		private void button3_Click(object sender, EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "PNG Image|*.png|JPG Image|*.jpg|BMP Image|*.bmp";
			sfd.Title = "Save Generated Image";
			sfd.ShowDialog();

			if (sfd.FileName != "") {
				FileStream fs = (FileStream)sfd.OpenFile();

				switch (sfd.FilterIndex) {
					case 1:
						pictureBox1.Image.Save(fs, ImageFormat.Png);
						break;
					case 2:
						pictureBox1.Image.Save(fs, ImageFormat.Jpeg);
						break;
					case 3:
						pictureBox1.Image.Save(fs, ImageFormat.Bmp);
						break;
				}

				fs.Close();
			}
		}
	}
}
