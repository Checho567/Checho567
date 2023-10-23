namespace Ahorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MarcFall = new System.Windows.Forms.GroupBox();
            this.mtbFallos = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbMarcador = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Letras = new System.Windows.Forms.GroupBox();
            this.lblLetrasUsadas = new System.Windows.Forms.Label();
            this.lblLetrasCorrectas = new System.Windows.Forms.Label();
            this.Imagenes = new System.Windows.Forms.GroupBox();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.gbTeclado = new System.Windows.Forms.GroupBox();
            this.btnM = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnRecargarJuego = new System.Windows.Forms.Button();
            this.MarcFall.SuspendLayout();
            this.Letras.SuspendLayout();
            this.Imagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.gbTeclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarcFall
            // 
            this.MarcFall.AutoSize = true;
            this.MarcFall.Controls.Add(this.mtbFallos);
            this.MarcFall.Controls.Add(this.label2);
            this.MarcFall.Controls.Add(this.mtbMarcador);
            this.MarcFall.Controls.Add(this.label1);
            this.MarcFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcFall.Location = new System.Drawing.Point(12, 12);
            this.MarcFall.Name = "MarcFall";
            this.MarcFall.Size = new System.Drawing.Size(173, 167);
            this.MarcFall.TabIndex = 0;
            this.MarcFall.TabStop = false;
            this.MarcFall.Text = "Sección 1";
            // 
            // mtbFallos
            // 
            this.mtbFallos.Location = new System.Drawing.Point(133, 100);
            this.mtbFallos.Mask = "9";
            this.mtbFallos.Name = "mtbFallos";
            this.mtbFallos.ReadOnly = true;
            this.mtbFallos.Size = new System.Drawing.Size(34, 34);
            this.mtbFallos.TabIndex = 3;
            this.mtbFallos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fallos(8)";
            // 
            // mtbMarcador
            // 
            this.mtbMarcador.Location = new System.Drawing.Point(133, 46);
            this.mtbMarcador.Mask = "9";
            this.mtbMarcador.Name = "mtbMarcador";
            this.mtbMarcador.ReadOnly = true;
            this.mtbMarcador.Size = new System.Drawing.Size(34, 34);
            this.mtbMarcador.TabIndex = 1;
            this.mtbMarcador.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcador:";
            // 
            // Letras
            // 
            this.Letras.Controls.Add(this.lblLetrasUsadas);
            this.Letras.Controls.Add(this.lblLetrasCorrectas);
            this.Letras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letras.Location = new System.Drawing.Point(202, 12);
            this.Letras.Name = "Letras";
            this.Letras.Size = new System.Drawing.Size(786, 167);
            this.Letras.TabIndex = 1;
            this.Letras.TabStop = false;
            this.Letras.Text = "Sección 2";
            // 
            // lblLetrasUsadas
            // 
            this.lblLetrasUsadas.AutoSize = true;
            this.lblLetrasUsadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetrasUsadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasUsadas.Location = new System.Drawing.Point(6, 103);
            this.lblLetrasUsadas.Name = "lblLetrasUsadas";
            this.lblLetrasUsadas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLetrasUsadas.Size = new System.Drawing.Size(2, 48);
            this.lblLetrasUsadas.TabIndex = 1;
            // 
            // lblLetrasCorrectas
            // 
            this.lblLetrasCorrectas.AutoSize = true;
            this.lblLetrasCorrectas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetrasCorrectas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasCorrectas.Location = new System.Drawing.Point(96, 35);
            this.lblLetrasCorrectas.Name = "lblLetrasCorrectas";
            this.lblLetrasCorrectas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLetrasCorrectas.Size = new System.Drawing.Size(2, 48);
            this.lblLetrasCorrectas.TabIndex = 0;
            // 
            // Imagenes
            // 
            this.Imagenes.Controls.Add(this.Imagen);
            this.Imagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imagenes.Location = new System.Drawing.Point(1059, 12);
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.Size = new System.Drawing.Size(173, 167);
            this.Imagenes.TabIndex = 2;
            this.Imagenes.TabStop = false;
            this.Imagenes.Text = "Sección 3";
            // 
            // Imagen
            // 
            this.Imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen.Image = global::Ahorcado.Properties.Resources.user_logo;
            this.Imagen.Location = new System.Drawing.Point(3, 30);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(167, 134);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            // 
            // gbTeclado
            // 
            this.gbTeclado.Controls.Add(this.btnM);
            this.gbTeclado.Controls.Add(this.btnZ);
            this.gbTeclado.Controls.Add(this.btnY);
            this.gbTeclado.Controls.Add(this.btnX);
            this.gbTeclado.Controls.Add(this.btnW);
            this.gbTeclado.Controls.Add(this.btnV);
            this.gbTeclado.Controls.Add(this.btnU);
            this.gbTeclado.Controls.Add(this.btnT);
            this.gbTeclado.Controls.Add(this.btnS);
            this.gbTeclado.Controls.Add(this.btnR);
            this.gbTeclado.Controls.Add(this.btnQ);
            this.gbTeclado.Controls.Add(this.btnP);
            this.gbTeclado.Controls.Add(this.btnO);
            this.gbTeclado.Controls.Add(this.btnN);
            this.gbTeclado.Controls.Add(this.btnL);
            this.gbTeclado.Controls.Add(this.btnK);
            this.gbTeclado.Controls.Add(this.btnJ);
            this.gbTeclado.Controls.Add(this.btnI);
            this.gbTeclado.Controls.Add(this.btnH);
            this.gbTeclado.Controls.Add(this.btnG);
            this.gbTeclado.Controls.Add(this.btnF);
            this.gbTeclado.Controls.Add(this.btnE);
            this.gbTeclado.Controls.Add(this.btnD);
            this.gbTeclado.Controls.Add(this.btnC);
            this.gbTeclado.Controls.Add(this.btnB);
            this.gbTeclado.Controls.Add(this.btnA);
            this.gbTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeclado.Location = new System.Drawing.Point(81, 203);
            this.gbTeclado.Name = "gbTeclado";
            this.gbTeclado.Size = new System.Drawing.Size(1092, 241);
            this.gbTeclado.TabIndex = 3;
            this.gbTeclado.TabStop = false;
            this.gbTeclado.Text = "Sección 4";
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(994, 47);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 71);
            this.btnM.TabIndex = 26;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZ.Location = new System.Drawing.Point(994, 153);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(75, 71);
            this.btnZ.TabIndex = 25;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(913, 153);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 71);
            this.btnY.TabIndex = 24;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(832, 153);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 71);
            this.btnX.TabIndex = 23;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(751, 153);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 71);
            this.btnW.TabIndex = 22;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(670, 153);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 71);
            this.btnV.TabIndex = 21;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(589, 153);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 71);
            this.btnU.TabIndex = 20;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(508, 153);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 71);
            this.btnT.TabIndex = 19;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(427, 153);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 71);
            this.btnS.TabIndex = 18;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(346, 153);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 71);
            this.btnR.TabIndex = 17;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(265, 153);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(75, 71);
            this.btnQ.TabIndex = 16;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(184, 153);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 71);
            this.btnP.TabIndex = 15;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(103, 153);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(75, 71);
            this.btnO.TabIndex = 14;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(22, 153);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 71);
            this.btnN.TabIndex = 13;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(913, 47);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 71);
            this.btnL.TabIndex = 11;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(832, 47);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(75, 71);
            this.btnK.TabIndex = 10;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(751, 47);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(75, 71);
            this.btnJ.TabIndex = 9;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(670, 47);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(75, 71);
            this.btnI.TabIndex = 8;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(589, 47);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(75, 71);
            this.btnH.TabIndex = 7;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(508, 47);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 71);
            this.btnG.TabIndex = 6;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(427, 47);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 71);
            this.btnF.TabIndex = 5;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(346, 47);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 71);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(265, 47);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 71);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(184, 47);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 71);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(103, 47);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 71);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(22, 47);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 71);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnRecargarJuego
            // 
            this.btnRecargarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarJuego.Location = new System.Drawing.Point(81, 480);
            this.btnRecargarJuego.Name = "btnRecargarJuego";
            this.btnRecargarJuego.Size = new System.Drawing.Size(133, 71);
            this.btnRecargarJuego.TabIndex = 27;
            this.btnRecargarJuego.Text = "Recargar juego";
            this.btnRecargarJuego.UseVisualStyleBackColor = true;
            this.btnRecargarJuego.Click += new System.EventHandler(this.btnRecargarJuego_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1244, 599);
            this.Controls.Add(this.btnRecargarJuego);
            this.Controls.Add(this.gbTeclado);
            this.Controls.Add(this.Imagenes);
            this.Controls.Add(this.Letras);
            this.Controls.Add(this.MarcFall);
            this.Name = "Form1";
            this.Text = "AHORCADO";
            this.MarcFall.ResumeLayout(false);
            this.MarcFall.PerformLayout();
            this.Letras.ResumeLayout(false);
            this.Letras.PerformLayout();
            this.Imagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.gbTeclado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MarcFall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbFallos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbMarcador;
        private System.Windows.Forms.GroupBox Letras;
        private System.Windows.Forms.Label lblLetrasCorrectas;
        private System.Windows.Forms.Label lblLetrasUsadas;
        private System.Windows.Forms.GroupBox Imagenes;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.GroupBox gbTeclado;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnRecargarJuego;
    }
}

