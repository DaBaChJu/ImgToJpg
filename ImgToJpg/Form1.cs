using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImgToJpg
{
	public partial class ImgToJpg : Form
	{

		public ImgToJpg()
		{
			InitializeComponent();
		}

		public ImgToJpg(string[] args)
		{

			InitializeComponent();

			if (args.Length > 0)
			{

				this.TopMost = true;

				if (MessageBox.Show(string.Format("{0} fichiers lus,les traiter?", args.Length), "Drag&Drop", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{

					GUI_progressBar.Maximum = args.Length;
					GUI_progressBar.Value = 0;
					GUI_progressBar.ForeColor = Color.FromArgb(192, 0, 0);

					this.TopMost = false;

					backgroundWorker1.RunWorkerAsync(args);

				}
				else
					this.TopMost = false;

			}

		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string [] données=(string[])e.Data.GetData(DataFormats.FileDrop);
			if (données != null && données.Length > 0)
			{

				this.TopMost = true;

				if (MessageBox.Show(string.Format("{0} fichiers reçus,continuer?", données.Length), "Drag&Drop", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{

					GUI_progressBar.Maximum = données.Length;
					GUI_progressBar.Value = 0;
					GUI_progressBar.ForeColor = Color.FromArgb(192, 0, 0);

					this.TopMost = false;

					backgroundWorker1.RunWorkerAsync(données);

				}
				else
					this.TopMost = false;

			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

			string[] données = e.Argument as string[];

			for(int i=0;i<données.Length;i++)
			{

				Bitmap tmp = (Bitmap)Bitmap.FromFile(données[i]);
				Bitmap tmp2 = new Bitmap(tmp);
				tmp.Dispose();

				données[i] = Path.ChangeExtension(données[i], ".jpg");

				tmp2.Save(données[i], ImageFormat.Jpeg);

				backgroundWorker1.ReportProgress(100 * (GUI_progressBar.Value + 1) / GUI_progressBar.Maximum);

				tmp2.Dispose();

			}

		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			GUI_progressBar.Value++;
			if (e.ProgressPercentage.ToString() != GUI_toolTip.GetToolTip(GUI_progressBar))
			{

				//init color: GUI_progressBar.ForeColor = Color.FromArgb(192, 0, 0);

				GUI_toolTip.SetToolTip(GUI_progressBar, string.Format(" {0:00} % ", e.ProgressPercentage));

				//if (e.ProgressPercentage == 25)
				//    GUI_progressBar.ForeColor = Color.FromArgb(255, 192, 0);else
				//if (e.ProgressPercentage == 50)
				//    GUI_progressBar.ForeColor = Color.FromArgb(192, 255, 0);else
				//if (e.ProgressPercentage == 75)
				//    GUI_progressBar.ForeColor = Color.FromArgb(0, 192, 0);

				if (e.ProgressPercentage <= 33)	//from red to orange
				{
					GUI_progressBar.ForeColor = Color.FromArgb(
						192 + (255 - 192) * e.ProgressPercentage / 33,			//from 192 to 255
						192 * e.ProgressPercentage / 33,						//from 0 to 192
						0);
				}
				else
				if (e.ProgressPercentage <= 66)		//from orange to yellow
				{
					GUI_progressBar.ForeColor = Color.FromArgb(
						255 - (255 - 192) * (e.ProgressPercentage - 33) / 33,	//from 255 to 192
						192 + (255 - 192) * (e.ProgressPercentage - 33) / 33,	//from 192 to 255
						0);
				}
				else
				if (e.ProgressPercentage <= 99)	//from yellow to green
				{
					GUI_progressBar.ForeColor = Color.FromArgb(
						192 - 192 * (e.ProgressPercentage - 66) / 33,			//from 192 to 0
						255 - (255 - 192) * (e.ProgressPercentage - 66) / 33,	//from 255 to 192
						0);
				}

				GUI_label_filequantity.Text = GUI_progressBar.Value.ToString() + " / " + GUI_progressBar.Maximum.ToString();

			}
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			GUI_progressBar.ForeColor = Color.FromArgb(0, 0, 255);
			this.TopMost = true;
			MessageBox.Show("Fin des opérations");
			this.TopMost = false;
		}
	}
}
