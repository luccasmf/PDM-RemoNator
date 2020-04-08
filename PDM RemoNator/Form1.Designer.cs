namespace PDM_RemoNator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofTodos = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.Nick = new System.Windows.Forms.ColumnHeader();
            this.Remos = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnLoadSubs = new System.Windows.Forms.Button();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lblRemo = new System.Windows.Forms.Label();
            this.lblInscritos = new System.Windows.Forms.Label();
            this.lblRemosToAdd = new System.Windows.Forms.Label();
            this.btnCreditar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ofSubs = new System.Windows.Forms.OpenFileDialog();
            this.saveJSON = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ofTodos
            // 
            this.ofTodos.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(22, 75);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(139, 42);
            this.btnLoadAll.TabIndex = 0;
            this.btnLoadAll.Text = "Carregar Extrato de Remos";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // Nick
            // 
            this.Nick.Name = "Nick";
            // 
            // Remos
            // 
            this.Remos.Name = "Remos";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            // 
            // btnLoadSubs
            // 
            this.btnLoadSubs.Location = new System.Drawing.Point(207, 75);
            this.btnLoadSubs.Name = "btnLoadSubs";
            this.btnLoadSubs.Size = new System.Drawing.Size(139, 42);
            this.btnLoadSubs.TabIndex = 0;
            this.btnLoadSubs.Text = "Carregar Subscribers";
            this.btnLoadSubs.UseVisualStyleBackColor = true;
            this.btnLoadSubs.Click += new System.EventHandler(this.btnLoadSubs_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "Nick";
            // 
            // lblRemo
            // 
            this.lblRemo.AutoSize = true;
            this.lblRemo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemo.ForeColor = System.Drawing.Color.Green;
            this.lblRemo.Location = new System.Drawing.Point(22, 36);
            this.lblRemo.Name = "lblRemo";
            this.lblRemo.Size = new System.Drawing.Size(0, 21);
            this.lblRemo.TabIndex = 2;
            // 
            // lblInscritos
            // 
            this.lblInscritos.AutoSize = true;
            this.lblInscritos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInscritos.ForeColor = System.Drawing.Color.Green;
            this.lblInscritos.Location = new System.Drawing.Point(207, 36);
            this.lblInscritos.Name = "lblInscritos";
            this.lblInscritos.Size = new System.Drawing.Size(74, 21);
            this.lblInscritos.TabIndex = 2;
            // 
            // lblRemosToAdd
            // 
            this.lblRemosToAdd.AutoSize = true;
            this.lblRemosToAdd.Location = new System.Drawing.Point(22, 138);
            this.lblRemosToAdd.Name = "lblRemosToAdd";
            this.lblRemosToAdd.Size = new System.Drawing.Size(104, 15);
            this.lblRemosToAdd.TabIndex = 4;
            this.lblRemosToAdd.Text = "Remos a adicionar";
            // 
            // btnCreditar
            // 
            this.btnCreditar.Location = new System.Drawing.Point(119, 177);
            this.btnCreditar.Name = "btnCreditar";
            this.btnCreditar.Size = new System.Drawing.Size(139, 39);
            this.btnCreditar.TabIndex = 5;
            this.btnCreditar.Text = "Creditar Remos";
            this.btnCreditar.UseVisualStyleBackColor = true;
            this.btnCreditar.Click += new System.EventHandler(this.btnCreditar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // ofSubs
            // 
            this.ofSubs.FileOk += new System.ComponentModel.CancelEventHandler(this.ofSubs_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 234);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCreditar);
            this.Controls.Add(this.lblRemosToAdd);
            this.Controls.Add(this.lblInscritos);
            this.Controls.Add(this.lblRemo);
            this.Controls.Add(this.btnLoadSubs);
            this.Controls.Add(this.btnLoadAll);
            this.Name = "Form1";
            this.Text = "Inscritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofTodos;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nick;
        private System.Windows.Forms.ColumnHeader Remos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnLoadSubs;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblRemo;
        private System.Windows.Forms.Label lblInscritos;
        private System.Windows.Forms.Label lblRemosToAdd;
        private System.Windows.Forms.Button btnCreditar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog ofSubs;
        private System.Windows.Forms.SaveFileDialog saveJSON;
    }
}

