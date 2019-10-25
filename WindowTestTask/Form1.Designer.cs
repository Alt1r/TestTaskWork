namespace WindowTestTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape5 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape6 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape7 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape8 = new DevExpress.XtraDiagram.DiagramShape();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3,
            this.diagramShape4,
            this.diagramShape5,
            this.diagramShape6,
            this.diagramShape7,
            this.diagramShape8});
            this.diagramControl1.Location = new System.Drawing.Point(12, 12);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramControl1.Size = new System.Drawing.Size(862, 514);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            // 
            // diagramShape1
            // 
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape1.Content = "12";
            this.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(140F, 120F);
            this.diagramShape1.Size = new System.Drawing.SizeF(100F, 75F);
            this.diagramShape1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            // 
            // diagramShape2
            // 
            this.diagramShape2.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1_4;
            this.diagramShape2.Content = "";
            this.diagramShape2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(370F, 120F);
            this.diagramShape2.Shape = DevExpress.Diagram.Core.BasicShapes.RoundedRectangle;
            this.diagramShape2.Size = new System.Drawing.SizeF(130F, 182F);
            this.diagramShape2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            // 
            // diagramShape3
            // 
            this.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape3.Content = "Авария";
            this.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(385F, 236F);
            this.diagramShape3.Size = new System.Drawing.SizeF(100F, 55F);
            this.diagramShape3.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant3;
            // 
            // diagramShape4
            // 
            this.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.diagramShape4.Content = "22";
            this.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(140F, 260F);
            this.diagramShape4.Shape = DevExpress.Diagram.Core.BasicShapes.RoundedRectangle;
            this.diagramShape4.Size = new System.Drawing.SizeF(100F, 55F);
            this.diagramShape4.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            // 
            // diagramShape5
            // 
            this.diagramShape5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape5.Position = new DevExpress.Utils.PointFloat(470F, 160F);
            this.diagramShape5.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape5.Size = new System.Drawing.SizeF(15F, 15F);
            // 
            // diagramShape6
            // 
            this.diagramShape6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape6.Position = new DevExpress.Utils.PointFloat(470F, 176F);
            this.diagramShape6.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape6.Size = new System.Drawing.SizeF(15F, 15F);
            // 
            // diagramShape7
            // 
            this.diagramShape7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape7.Position = new DevExpress.Utils.PointFloat(470F, 192F);
            this.diagramShape7.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape7.Size = new System.Drawing.SizeF(15F, 15F);
            // 
            // diagramShape8
            // 
            this.diagramShape8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape8.Content = "";
            this.diagramShape8.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape8.Position = new DevExpress.Utils.PointFloat(470F, 208F);
            this.diagramShape8.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape8.Size = new System.Drawing.SizeF(15F, 15F);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 559);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form1";
            this.Text = "Диаграмма";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.XtraDiagram.DiagramShape diagramShape4;
        private DevExpress.XtraDiagram.DiagramShape diagramShape5;
        private DevExpress.XtraDiagram.DiagramShape diagramShape6;
        private DevExpress.XtraDiagram.DiagramShape diagramShape7;
        private DevExpress.XtraDiagram.DiagramShape diagramShape8;
    }
}

