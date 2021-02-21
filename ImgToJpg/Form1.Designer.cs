namespace ImgToJpg
{
	partial class ImgToJpg
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.GUI_progressBar = new System.Windows.Forms.ProgressBar();
			this.GUI_toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.GUI_label_filequantity = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Déplacer les fichiers dans la fenêtre pour lancer la";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "conversion en .jpg des images glissées";
			// 
			// GUI_progressBar
			// 
			this.GUI_progressBar.Location = new System.Drawing.Point(12, 238);
			this.GUI_progressBar.Name = "GUI_progressBar";
			this.GUI_progressBar.Size = new System.Drawing.Size(268, 23);
			this.GUI_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.GUI_progressBar.TabIndex = 2;
			// 
			// GUI_toolTip
			// 
			this.GUI_toolTip.AutoPopDelay = 1000;
			this.GUI_toolTip.InitialDelay = 500;
			this.GUI_toolTip.ReshowDelay = 100;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			// 
			// GUI_label_filequantity
			// 
			this.GUI_label_filequantity.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GUI_label_filequantity.Location = new System.Drawing.Point(12, 193);
			this.GUI_label_filequantity.Name = "GUI_label_filequantity";
			this.GUI_label_filequantity.Size = new System.Drawing.Size(268, 23);
			this.GUI_label_filequantity.TabIndex = 3;
			this.GUI_label_filequantity.Text = "/";
			this.GUI_label_filequantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ImgToJpg
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.GUI_label_filequantity);
			this.Controls.Add(this.GUI_progressBar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ImgToJpg";
			this.Text = "ImgToJpg";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar GUI_progressBar;
		private System.Windows.Forms.ToolTip GUI_toolTip;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label GUI_label_filequantity;
	}
}

