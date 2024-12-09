namespace Recurcividad_con_la_potencia_de_un_numero
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
            BtnCalculate = new Button();
            TxtNumberP = new TextBox();
            LstViewData = new ListView();
            label1 = new Label();
            label2 = new Label();
            TxtNumber = new TextBox();
            SuspendLayout();
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(126, 215);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 23);
            BtnCalculate.TabIndex = 0;
            BtnCalculate.Text = "Calcular";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // TxtNumberP
            // 
            TxtNumberP.Location = new Point(195, 168);
            TxtNumberP.Name = "TxtNumberP";
            TxtNumberP.Size = new Size(123, 23);
            TxtNumberP.TabIndex = 1;
            // 
            // LstViewData
            // 
            LstViewData.Location = new Point(392, 12);
            LstViewData.Name = "LstViewData";
            LstViewData.Size = new Size(212, 353);
            LstViewData.TabIndex = 2;
            LstViewData.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 135);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Potencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 135);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Numero";
            // 
            // TxtNumber
            // 
            TxtNumber.Location = new Point(38, 168);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(123, 23);
            TxtNumber.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 385);
            Controls.Add(TxtNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LstViewData);
            Controls.Add(TxtNumberP);
            Controls.Add(BtnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalculate;
        private TextBox TxtNumberP;
        private ListView LstViewData;
        private Label label1;
        private Label label2;
        private TextBox TxtNumber;
    }
}
