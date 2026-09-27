namespace Cafe_Project.AllUserControls
{
    partial class UC_AddItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            txtCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 118, 221);
            label1.Location = new Point(570, 73);
            label1.Name = "label1";
            label1.Size = new Size(281, 51);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13F);
            label2.Location = new Point(459, 460);
            label2.Name = "label2";
            label2.Size = new Size(76, 36);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13F);
            label3.Location = new Point(459, 327);
            label3.Name = "label3";
            label3.Size = new Size(151, 36);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13F);
            label4.Location = new Point(459, 188);
            label4.Name = "label4";
            label4.Size = new Size(125, 36);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // btnAddItem
            // 
            btnAddItem.BorderRadius = 30;
            btnAddItem.CustomizableEdges = customizableEdges1;
            btnAddItem.DisabledState.BorderColor = Color.DarkGray;
            btnAddItem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItem.FillColor = Color.FromArgb(0, 118, 225);
            btnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(573, 603);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddItem.Size = new Size(270, 68);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.Transparent;
            txtCategory.CustomizableEdges = customizableEdges3;
            txtCategory.DrawMode = DrawMode.OwnerDrawFixed;
            txtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            txtCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.ForeColor = Color.Black;
            txtCategory.ItemHeight = 30;
            txtCategory.Items.AddRange(new object[] { "Cake", "Soft Drink", "South Indian", "Thali", "Indian" });
            txtCategory.Location = new Point(459, 258);
            txtCategory.Name = "txtCategory";
            txtCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCategory.Size = new Size(493, 36);
            txtCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCategory.TabIndex = 5;
            txtCategory.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // txtItemName
            // 
            txtItemName.CustomizableEdges = customizableEdges5;
            txtItemName.DefaultText = "";
            txtItemName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtItemName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtItemName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.Font = new Font("Comic Sans MS", 10F);
            txtItemName.ForeColor = Color.Black;
            txtItemName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.Location = new Point(459, 383);
            txtItemName.Margin = new Padding(5, 6, 5, 6);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "";
            txtItemName.SelectedText = "";
            txtItemName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtItemName.Size = new Size(493, 47);
            txtItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtItemName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges7;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Comic Sans MS", 10F);
            txtPrice.ForeColor = Color.Black;
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(459, 518);
            txtPrice.Margin = new Padding(5, 6, 5, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPrice.Size = new Size(493, 47);
            txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPrice.TabIndex = 7;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_AddItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtPrice);
            Controls.Add(txtItemName);
            Controls.Add(txtCategory);
            Controls.Add(btnAddItem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddItems";
            Size = new Size(1068, 757);
            Leave += UC_AddItems_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2ComboBox txtCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
