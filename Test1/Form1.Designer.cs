namespace Test1
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
            this.txtFirstSide = new System.Windows.Forms.TextBox();
            this.txtSecondSide = new System.Windows.Forms.TextBox();
            this.txtThirdSide = new System.Windows.Forms.TextBox();
            this.OutputTriangles = new System.Windows.Forms.TextBox();
            this.DisplayTriangles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTriangle = new System.Windows.Forms.Button();
            this.DisplayRectangular = new System.Windows.Forms.Button();
            this.TriangleArea = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OutputRectangular = new System.Windows.Forms.TextBox();
            this.txtHypotenuse = new System.Windows.Forms.TextBox();
            this.txtSecondLeg = new System.Windows.Forms.TextBox();
            this.txtFirstLeg = new System.Windows.Forms.TextBox();
            this.AddRectangular = new System.Windows.Forms.Button();
            this.MaxHypotenuse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstSide
            // 
            this.txtFirstSide.Location = new System.Drawing.Point(170, 50);
            this.txtFirstSide.Name = "txtFirstSide";
            this.txtFirstSide.Size = new System.Drawing.Size(160, 22);
            this.txtFirstSide.TabIndex = 0;
            // 
            // txtSecondSide
            // 
            this.txtSecondSide.Location = new System.Drawing.Point(170, 120);
            this.txtSecondSide.Name = "txtSecondSide";
            this.txtSecondSide.Size = new System.Drawing.Size(160, 22);
            this.txtSecondSide.TabIndex = 1;
            // 
            // txtThirdSide
            // 
            this.txtThirdSide.Location = new System.Drawing.Point(170, 190);
            this.txtThirdSide.Name = "txtThirdSide";
            this.txtThirdSide.Size = new System.Drawing.Size(160, 22);
            this.txtThirdSide.TabIndex = 2;
            // 
            // OutputTriangles
            // 
            this.OutputTriangles.Location = new System.Drawing.Point(30, 315);
            this.OutputTriangles.Multiline = true;
            this.OutputTriangles.Name = "OutputTriangles";
            this.OutputTriangles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTriangles.Size = new System.Drawing.Size(550, 295);
            this.OutputTriangles.TabIndex = 3;
            // 
            // DisplayTriangles
            // 
            this.DisplayTriangles.Location = new System.Drawing.Point(390, 105);
            this.DisplayTriangles.Name = "DisplayTriangles";
            this.DisplayTriangles.Size = new System.Drawing.Size(190, 85);
            this.DisplayTriangles.TabIndex = 4;
            this.DisplayTriangles.Text = "Display data for all triangles";
            this.DisplayTriangles.UseVisualStyleBackColor = true;
            this.DisplayTriangles.Click += new System.EventHandler(this.DisplayTriangles_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Third side :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "First side :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Second side :";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(610, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 670);
            this.label4.TabIndex = 8;
            // 
            // AddTriangle
            // 
            this.AddTriangle.Location = new System.Drawing.Point(390, 10);
            this.AddTriangle.Name = "AddTriangle";
            this.AddTriangle.Size = new System.Drawing.Size(190, 85);
            this.AddTriangle.TabIndex = 10;
            this.AddTriangle.Text = "Add a triangle";
            this.AddTriangle.UseVisualStyleBackColor = true;
            this.AddTriangle.Click += new System.EventHandler(this.AddTriangle_Click);
            // 
            // DisplayRectangular
            // 
            this.DisplayRectangular.Location = new System.Drawing.Point(1000, 105);
            this.DisplayRectangular.Name = "DisplayRectangular";
            this.DisplayRectangular.Size = new System.Drawing.Size(190, 85);
            this.DisplayRectangular.TabIndex = 11;
            this.DisplayRectangular.Text = "Display data on all rectangular triangles";
            this.DisplayRectangular.UseVisualStyleBackColor = true;
            this.DisplayRectangular.Click += new System.EventHandler(this.DisplayRectangular_Click);
            // 
            // TriangleArea
            // 
            this.TriangleArea.Location = new System.Drawing.Point(390, 200);
            this.TriangleArea.Name = "TriangleArea";
            this.TriangleArea.Size = new System.Drawing.Size(190, 85);
            this.TriangleArea.TabIndex = 12;
            this.TriangleArea.Text = "Find the average area of the triangles";
            this.TriangleArea.UseVisualStyleBackColor = true;
            this.TriangleArea.Click += new System.EventHandler(this.TriangleArea_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(640, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Second leg :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(640, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "First leg :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(640, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hypotenuse :";
            // 
            // OutputRectangular
            // 
            this.OutputRectangular.Location = new System.Drawing.Point(640, 315);
            this.OutputRectangular.Multiline = true;
            this.OutputRectangular.Name = "OutputRectangular";
            this.OutputRectangular.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputRectangular.Size = new System.Drawing.Size(550, 295);
            this.OutputRectangular.TabIndex = 16;
            // 
            // txtHypotenuse
            // 
            this.txtHypotenuse.Location = new System.Drawing.Point(780, 190);
            this.txtHypotenuse.Name = "txtHypotenuse";
            this.txtHypotenuse.Size = new System.Drawing.Size(160, 22);
            this.txtHypotenuse.TabIndex = 15;
            // 
            // txtSecondLeg
            // 
            this.txtSecondLeg.Location = new System.Drawing.Point(780, 120);
            this.txtSecondLeg.Name = "txtSecondLeg";
            this.txtSecondLeg.Size = new System.Drawing.Size(160, 22);
            this.txtSecondLeg.TabIndex = 14;
            // 
            // txtFirstLeg
            // 
            this.txtFirstLeg.Location = new System.Drawing.Point(780, 50);
            this.txtFirstLeg.Name = "txtFirstLeg";
            this.txtFirstLeg.Size = new System.Drawing.Size(160, 22);
            this.txtFirstLeg.TabIndex = 13;
            // 
            // AddRectangular
            // 
            this.AddRectangular.Location = new System.Drawing.Point(1000, 10);
            this.AddRectangular.Name = "AddRectangular";
            this.AddRectangular.Size = new System.Drawing.Size(190, 85);
            this.AddRectangular.TabIndex = 20;
            this.AddRectangular.Text = "Add a rectangular triangle";
            this.AddRectangular.UseVisualStyleBackColor = true;
            this.AddRectangular.Click += new System.EventHandler(this.AddRectangular_Click);
            // 
            // SmallHypotenuse
            // 
            this.MaxHypotenuse.Location = new System.Drawing.Point(1000, 200);
            this.MaxHypotenuse.Name = "MaxHypotenuse";
            this.MaxHypotenuse.Size = new System.Drawing.Size(190, 85);
            this.MaxHypotenuse.TabIndex = 21;
            this.MaxHypotenuse.Text = "Find the triangle with the maximum hypotenuse";
            this.MaxHypotenuse.UseVisualStyleBackColor = true;
            this.MaxHypotenuse.Click += new System.EventHandler(this.MaxHypotenuse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Output for a triangles :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Output for a rectangular triangles :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 623);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MaxHypotenuse);
            this.Controls.Add(this.AddRectangular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OutputRectangular);
            this.Controls.Add(this.txtHypotenuse);
            this.Controls.Add(this.txtSecondLeg);
            this.Controls.Add(this.txtFirstLeg);
            this.Controls.Add(this.TriangleArea);
            this.Controls.Add(this.DisplayRectangular);
            this.Controls.Add(this.AddTriangle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayTriangles);
            this.Controls.Add(this.OutputTriangles);
            this.Controls.Add(this.txtThirdSide);
            this.Controls.Add(this.txtSecondSide);
            this.Controls.Add(this.txtFirstSide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstSide;
        private System.Windows.Forms.TextBox txtSecondSide;
        private System.Windows.Forms.TextBox txtThirdSide;
        private System.Windows.Forms.TextBox OutputTriangles;
        private System.Windows.Forms.Button DisplayTriangles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddTriangle;
        private System.Windows.Forms.Button DisplayRectangular;
        private System.Windows.Forms.Button TriangleArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OutputRectangular;
        private System.Windows.Forms.TextBox txtHypotenuse;
        private System.Windows.Forms.TextBox txtSecondLeg;
        private System.Windows.Forms.TextBox txtFirstLeg;
        private System.Windows.Forms.Button AddRectangular;
        private System.Windows.Forms.Button MaxHypotenuse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

