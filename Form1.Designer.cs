namespace SortStrApp
{
    partial class frm_SortStrApp
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
            txb_StrInput = new TextBox();
            cbb_MVC = new ComboBox();
            btn_Sort = new Button();
            lbl_Output = new Label();
            SuspendLayout();
            // 
            // txb_StrInput
            // 
            txb_StrInput.Font = new Font("Lucida Console", 11.25F);
            txb_StrInput.Location = new Point(29, 29);
            txb_StrInput.Name = "txb_StrInput";
            txb_StrInput.PlaceholderText = "Input here";
            txb_StrInput.Size = new Size(299, 22);
            txb_StrInput.TabIndex = 1;
            // 
            // cbb_MVC
            // 
            cbb_MVC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_MVC.FlatStyle = FlatStyle.Flat;
            cbb_MVC.Font = new Font("Lucida Console", 11.25F);
            cbb_MVC.FormattingEnabled = true;
            cbb_MVC.Location = new Point(29, 75);
            cbb_MVC.Name = "cbb_MVC";
            cbb_MVC.Size = new Size(201, 23);
            cbb_MVC.TabIndex = 2;
            // 
            // btn_Sort
            // 
            btn_Sort.Font = new Font("Lucida Console", 11.25F);
            btn_Sort.Location = new Point(236, 75);
            btn_Sort.Name = "btn_Sort";
            btn_Sort.Size = new Size(92, 23);
            btn_Sort.TabIndex = 3;
            btn_Sort.Text = "SORT";
            btn_Sort.UseVisualStyleBackColor = true;
            btn_Sort.Click += btn_Sort_Click;
            // 
            // lbl_Output
            // 
            lbl_Output.BackColor = Color.DimGray;
            lbl_Output.Font = new Font("Lucida Console", 11.25F);
            lbl_Output.ForeColor = SystemColors.ControlLightLight;
            lbl_Output.Location = new Point(29, 117);
            lbl_Output.Name = "lbl_Output";
            lbl_Output.Size = new Size(299, 117);
            lbl_Output.TabIndex = 4;
            lbl_Output.Text = "Output will be display here";
            lbl_Output.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_SortStrApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 262);
            Controls.Add(lbl_Output);
            Controls.Add(btn_Sort);
            Controls.Add(cbb_MVC);
            Controls.Add(txb_StrInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frm_SortStrApp";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sorting String Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_StrInput;
        private ComboBox cbb_MVC;
        private Button btn_Sort;
        private Label lbl_Output;
    }
}
