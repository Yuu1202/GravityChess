namespace FormClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boardLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.coordinates = new System.Windows.Forms.ToolTip(this.components);
            // 
            // boardLayoutPanel
            // 
            this.boardLayoutPanel.ColumnCount = 8;
            this.boardLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < 8; i++)
                this.boardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardLayoutPanel.RowCount = 8;
            this.boardLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < 8; i++)
                this.boardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.boardLayoutPanel.Name = "boardLayoutPanel";
            this.boardLayoutPanel.Size = new System.Drawing.Size(624, 536);
            this.boardLayoutPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 536);
            this.Controls.Add(this.boardLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel boardLayoutPanel;
        private System.Windows.Forms.ToolTip coordinates;
    }
}

