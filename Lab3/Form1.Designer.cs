
namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxInputWord = new System.Windows.Forms.TextBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.labelTranslate = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxPolish = new System.Windows.Forms.TextBox();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelPolish = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonRemoveWord = new System.Windows.Forms.Button();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.buttonShowHistory = new System.Windows.Forms.Button();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.comboBoxTestLanguage = new System.Windows.Forms.ComboBox();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.listBoxAllWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(337, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(525, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Program do nauki języka angielskiego";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxInputWord
            // 
            this.textBoxInputWord.Location = new System.Drawing.Point(273, 82);
            this.textBoxInputWord.Multiline = true;
            this.textBoxInputWord.Name = "textBoxInputWord";
            this.textBoxInputWord.Size = new System.Drawing.Size(156, 26);
            this.textBoxInputWord.TabIndex = 1;
            this.textBoxInputWord.TextChanged += new System.EventHandler(this.textBoxInputWord_TextChanged);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(406, 124);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(131, 23);
            this.buttonTranslate.TabIndex = 2;
            this.buttonTranslate.Text = "PRZETŁUMACZ";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "Polski -> Angielski ",
            "Angielski -> Polski"});
            this.comboBoxDirection.Location = new System.Drawing.Point(840, 161);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDirection.TabIndex = 5;
            this.comboBoxDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirection_SelectedIndexChanged);
            // 
            // labelTranslate
            // 
            this.labelTranslate.AutoSize = true;
            this.labelTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTranslate.Location = new System.Drawing.Point(12, 83);
            this.labelTranslate.Name = "labelTranslate";
            this.labelTranslate.Size = new System.Drawing.Size(242, 16);
            this.labelTranslate.TabIndex = 7;
            this.labelTranslate.Text = "Wpisz słowo do przetłumaczenia:";
            this.labelTranslate.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(50, 222);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnglish.TabIndex = 8;
            this.textBoxEnglish.TextChanged += new System.EventHandler(this.textBoxEnglish_TextChanged);
            // 
            // textBoxPolish
            // 
            this.textBoxPolish.Location = new System.Drawing.Point(232, 222);
            this.textBoxPolish.Name = "textBoxPolish";
            this.textBoxPolish.Size = new System.Drawing.Size(100, 20);
            this.textBoxPolish.TabIndex = 9;
            this.textBoxPolish.TextChanged += new System.EventHandler(this.textBoxPolish_TextChanged);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(88, 206);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(35, 13);
            this.labelEnglish.TabIndex = 10;
            this.labelEnglish.Text = "label6";
            this.labelEnglish.Click += new System.EventHandler(this.labelEnglish_Click);
            // 
            // labelPolish
            // 
            this.labelPolish.AutoSize = true;
            this.labelPolish.Location = new System.Drawing.Point(270, 206);
            this.labelPolish.Name = "labelPolish";
            this.labelPolish.Size = new System.Drawing.Size(35, 13);
            this.labelPolish.TabIndex = 11;
            this.labelPolish.Text = "label7";
            this.labelPolish.Click += new System.EventHandler(this.labelPolish_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(476, 91);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 13);
            this.labelResult.TabIndex = 12;
            this.labelResult.Text = "label8";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(155, 315);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(161, 29);
            this.buttonShowAll.TabIndex = 13;
            this.buttonShowAll.Text = "Wyświetl listę wszystkich słów";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonRemoveWord
            // 
            this.buttonRemoveWord.Location = new System.Drawing.Point(239, 124);
            this.buttonRemoveWord.Name = "buttonRemoveWord";
            this.buttonRemoveWord.Size = new System.Drawing.Size(160, 23);
            this.buttonRemoveWord.TabIndex = 14;
            this.buttonRemoveWord.Text = "Usuń słowo ze słownika";
            this.buttonRemoveWord.UseVisualStyleBackColor = true;
            this.buttonRemoveWord.Click += new System.EventHandler(this.buttonRemoveWord_Click);
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Location = new System.Drawing.Point(29, 124);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(204, 23);
            this.buttonAddWord.TabIndex = 15;
            this.buttonAddWord.Text = "Dodaj słowo do słownika";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // buttonShowHistory
            // 
            this.buttonShowHistory.Location = new System.Drawing.Point(569, 315);
            this.buttonShowHistory.Name = "buttonShowHistory";
            this.buttonShowHistory.Size = new System.Drawing.Size(174, 29);
            this.buttonShowHistory.TabIndex = 16;
            this.buttonShowHistory.Text = "Wyświetl historię";
            this.buttonShowHistory.UseVisualStyleBackColor = true;
            this.buttonShowHistory.Click += new System.EventHandler(this.buttonShowHistory_Click);
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(799, 430);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(365, 49);
            this.buttonStartTest.TabIndex = 17;
            this.buttonStartTest.Text = "ROZPOCZNIJ TEST ZNAJOMOŚCI SŁÓWEK";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // comboBoxTestLanguage
            // 
            this.comboBoxTestLanguage.FormattingEnabled = true;
            this.comboBoxTestLanguage.Items.AddRange(new object[] {
            "Polski",
            "Angielski"});
            this.comboBoxTestLanguage.Location = new System.Drawing.Point(1043, 161);
            this.comboBoxTestLanguage.Name = "comboBoxTestLanguage";
            this.comboBoxTestLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTestLanguage.TabIndex = 18;
            this.comboBoxTestLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestLanguage_SelectedIndexChanged);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(443, 291);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(120, 186);
            this.listBoxHistory.TabIndex = 19;
            this.listBoxHistory.SelectedIndexChanged += new System.EventHandler(this.listBoxHistory_SelectedIndexChanged);
            // 
            // listBoxAllWords
            // 
            this.listBoxAllWords.FormattingEnabled = true;
            this.listBoxAllWords.Location = new System.Drawing.Point(29, 291);
            this.listBoxAllWords.Name = "listBoxAllWords";
            this.listBoxAllWords.Size = new System.Drawing.Size(120, 186);
            this.listBoxAllWords.TabIndex = 20;
            this.listBoxAllWords.SelectedIndexChanged += new System.EventHandler(this.listBoxAllWords_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1199, 502);
            this.Controls.Add(this.listBoxAllWords);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.comboBoxTestLanguage);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.buttonShowHistory);
            this.Controls.Add(this.buttonAddWord);
            this.Controls.Add(this.buttonRemoveWord);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelPolish);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.textBoxPolish);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.labelTranslate);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.textBoxInputWord);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxInputWord;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Label labelTranslate;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxPolish;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelPolish;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonRemoveWord;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.Button buttonShowHistory;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.ComboBox comboBoxTestLanguage;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.ListBox listBoxAllWords;
    }
}

