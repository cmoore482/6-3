namespace SimpleCalculator
{
    partial class Calc
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
            Operand1 = new Label();
            TxtOperand1 = new TextBox();
            TxtOperator = new TextBox();
            TxtOperand2 = new TextBox();
            TxtResult = new TextBox();
            Exit = new Button();
            Calculate = new Button();
            Operator = new Label();
            Operand2 = new Label();
            Result = new Label();
            SuspendLayout();
            // 
            // Operand1
            // 
            Operand1.AutoSize = true;
            Operand1.Location = new Point(25, 33);
            Operand1.Name = "Operand1";
            Operand1.Size = new Size(65, 15);
            Operand1.TabIndex = 0;
            Operand1.Text = "Operand 1:";
            // 
            // TxtOperand1
            // 
            TxtOperand1.Location = new Point(100, 25);
            TxtOperand1.Name = "TxtOperand1";
            TxtOperand1.Size = new Size(100, 23);
            TxtOperand1.TabIndex = 1;
            // 
            // TxtOperator
            // 
            TxtOperator.Location = new Point(100, 54);
            TxtOperator.Name = "TxtOperator";
            TxtOperator.Size = new Size(39, 23);
            TxtOperator.TabIndex = 2;
            TxtOperator.TextChanged += TxtOperator_TextChanged;
            // 
            // TxtOperand2
            // 
            TxtOperand2.Location = new Point(100, 83);
            TxtOperand2.Name = "TxtOperand2";
            TxtOperand2.Size = new Size(100, 23);
            TxtOperand2.TabIndex = 3;
            // 
            // TxtResult
            // 
            TxtResult.Enabled = false;
            TxtResult.Location = new Point(100, 112);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(100, 23);
            TxtResult.TabIndex = 4;
            // 
            // Exit
            // 
            Exit.Location = new Point(125, 152);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 6;
            Exit.Text = "E&xit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(25, 152);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(75, 23);
            Calculate.TabIndex = 5;
            Calculate.Text = "&Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Operator
            // 
            Operator.AutoSize = true;
            Operator.Location = new Point(25, 62);
            Operator.Name = "Operator";
            Operator.Size = new Size(57, 15);
            Operator.TabIndex = 7;
            Operator.Text = "Operator:";
            // 
            // Operand2
            // 
            Operand2.AutoSize = true;
            Operand2.Location = new Point(24, 91);
            Operand2.Name = "Operand2";
            Operand2.Size = new Size(65, 15);
            Operand2.TabIndex = 8;
            Operand2.Text = "Operand 2:";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(25, 120);
            Result.Name = "Result";
            Result.Size = new Size(42, 15);
            Result.TabIndex = 9;
            Result.Text = "Result:";
            // 
            // Calc
            // 
            AcceptButton = Calculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Exit;
            ClientSize = new Size(231, 189);
            Controls.Add(Result);
            Controls.Add(Operand2);
            Controls.Add(Operator);
            Controls.Add(Calculate);
            Controls.Add(Exit);
            Controls.Add(TxtResult);
            Controls.Add(TxtOperand2);
            Controls.Add(TxtOperator);
            Controls.Add(TxtOperand1);
            Controls.Add(Operand1);
            Name = "Calc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Operand1;
        private TextBox TxtOperand1;
        private TextBox TxtOperator;
        private TextBox TxtOperand2;
        private TextBox TxtResult;
        private Button Exit;
        private Button Calculate;
        private Label Operator;
        private Label Operand2;
        private Label Result;
    }
}
