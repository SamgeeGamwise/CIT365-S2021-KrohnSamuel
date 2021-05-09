
namespace MegaDesk_Krohn
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.label2 = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deskDrawers = new System.Windows.Forms.NumericUpDown();
            this.submitNewQuote = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shippingDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(54, 81);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(120, 23);
            this.deskWidth.TabIndex = 2;
            this.deskWidth.ValueChanged += new System.EventHandler(this.deskWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desk Width";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(54, 125);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(120, 23);
            this.deskDepth.TabIndex = 3;
            this.deskDepth.ValueChanged += new System.EventHandler(this.deskDepth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desk Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "# of Drawers";
            // 
            // deskDrawers
            // 
            this.deskDrawers.Location = new System.Drawing.Point(54, 169);
            this.deskDrawers.Name = "deskDrawers";
            this.deskDrawers.Size = new System.Drawing.Size(120, 23);
            this.deskDrawers.TabIndex = 4;
            this.deskDrawers.ValueChanged += new System.EventHandler(this.deskDrawers_ValueChanged);
            // 
            // submitNewQuote
            // 
            this.submitNewQuote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitNewQuote.Location = new System.Drawing.Point(212, 294);
            this.submitNewQuote.Name = "submitNewQuote";
            this.submitNewQuote.Size = new System.Drawing.Size(150, 40);
            this.submitNewQuote.TabIndex = 7;
            this.submitNewQuote.Text = "Submit";
            this.submitNewQuote.UseVisualStyleBackColor = false;
            this.submitNewQuote.Click += new System.EventHandler(this.submitNewQuote_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(54, 37);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(212, 23);
            this.nameInput.TabIndex = 1;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Location = new System.Drawing.Point(54, 213);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(138, 23);
            this.surfaceMaterial.TabIndex = 5;
            this.surfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Material";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Days to Ship";
            // 
            // shippingDays
            // 
            this.shippingDays.FormattingEnabled = true;
            this.shippingDays.Location = new System.Drawing.Point(54, 257);
            this.shippingDays.Name = "shippingDays";
            this.shippingDays.Size = new System.Drawing.Size(138, 23);
            this.shippingDays.TabIndex = 6;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shippingDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.submitNewQuote);
            this.Controls.Add(this.deskDrawers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown deskDrawers;
        private System.Windows.Forms.Button submitNewQuote;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox shippingDays;
    }
}