namespace Pryoyecto_Csharp_y_MySQL
{
    partial class FormId
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnIdUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(34, 47);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(55, 20);
            this.txtIdUsuario.TabIndex = 1;
            // 
            // btnIdUpdate
            // 
            this.btnIdUpdate.Location = new System.Drawing.Point(23, 73);
            this.btnIdUpdate.Name = "btnIdUpdate";
            this.btnIdUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnIdUpdate.TabIndex = 2;
            this.btnIdUpdate.Text = "Update";
            this.btnIdUpdate.UseVisualStyleBackColor = true;
            this.btnIdUpdate.Click += new System.EventHandler(this.btnIdUpdate_Click);
            // 
            // FormId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 113);
            this.Controls.Add(this.btnIdUpdate);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormId";
            this.Text = "Id Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnIdUpdate;
    }
}