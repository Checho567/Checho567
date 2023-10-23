using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {

        //Para seleccionar un elemento de la lista multidimensional,
        //primero van las filas y despues van las columnas.
        string[,] palabras =
        {
            {"PELOTA", "CELULAR"},
            {"CAMISA", "TROFEO"},
            {"ESFERO", "RAZONAR"},
            {"AUDIFONO", "COMPUTADORA"},
            {"COCINA", "IMPRESORA"},
        };

        Random random = new Random();
        string palabraAleatoria;
        string palabraAdivinada;
        bool palabraAdivinadaCompleta = false;
        int contadorFallos = 0;
        int contadorAciertos = 0;
        int fallosTotales = 8;
        int intentos;

        public Form1()
        {
            InitializeComponent();
            int filas = palabras.GetLength(0);
            int columnas = palabras.GetLength(1);

            int filaAleatoria = random.Next(filas);
            int columnaAleatoria = random.Next(columnas);

            palabraAleatoria = palabras[filaAleatoria, columnaAleatoria];
            lblLetrasCorrectas.Text = palabraAleatoria;

            palabraAdivinada = new string('_', palabraAleatoria.Length);
            lblLetrasCorrectas.Text = EspacioPalabraAdivinada(palabraAdivinada);
        }

        private string letrasUsadas = "";

        private string EspacioPalabraAdivinada(string palabra)
        {
            return palabra.Replace("_", " _ ");
        }

        private void ActualizarPalabraAdivinada(char letra)
        {
            if(palabraAdivinadaCompleta)
            {
                return;
            }

            StringBuilder nuevaPalabra = new StringBuilder(palabraAdivinada);
            bool coincidencia = false;

            for (int i = 0; i < palabraAleatoria.Length; i++)
            {
                if (palabraAleatoria[i] == letra)
                {
                    nuevaPalabra[i * 1] = letra;
                    coincidencia = true;
                }
            }

            palabraAdivinada = nuevaPalabra.ToString();
            lblLetrasCorrectas.Text = EspacioPalabraAdivinada(palabraAdivinada);

            if (!EspacioPalabraAdivinada(palabraAdivinada).Contains('_'))
            {
                palabraAdivinadaCompleta = true;
                MessageBox.Show("¡Juego Terminado, felicitaciones! 😀");
                InicializarTeclado();
                ReiniciarInputs();
                contadorAciertos++;
                mtbMarcador.Text = contadorAciertos.ToString();
                contadorFallos = 0;
                mtbFallos.Text = contadorFallos.ToString();
                
            } else if (!coincidencia)
            {
                contadorFallos++;
                mtbFallos.Text = contadorFallos.ToString();

                if (contadorFallos == fallosTotales)
                {
                    MessageBox.Show("Has alcanzado 8 fallos. ¡Perdiste el juego! 😞");
                    Imagen.Image = Ahorcado.Properties.Resources.X;
                    palabraAdivinadaCompleta = false;
                    InicializarTeclado();
                    ReiniciarInputs();
                    contadorAciertos = 0;
                    mtbMarcador.Text = contadorAciertos.ToString();
                    contadorFallos = 0;
                    mtbFallos.Text = contadorFallos.ToString();
                } else
                {
                    Imagen.Image = Ahorcado.Properties.Resources.user_logo;
                }
            }
        }

        //REINICIAR ACTIVACION DE BOTONES
        public void InicializarTeclado()
        {
            if (btnA.Enabled == false)
            {
                btnA.Enabled = true;
            }
            if (btnB.Enabled == false)
            {
                btnB.Enabled = true;
            }
            if (btnC.Enabled == false)
            {
                btnC.Enabled = true;
            }
            if (btnD.Enabled == false)
            {
                btnD.Enabled = true;
            }
            if (btnE.Enabled == false)
            {
                btnE.Enabled = true;
            }
            if (btnF.Enabled == false)
            {
                btnF.Enabled = true;
            }
            if (btnG.Enabled == false)
            {
                btnG.Enabled = true;
            }
            if (btnH.Enabled == false)
            {
                btnH.Enabled = true;
            }
            if (btnI.Enabled == false)
            {
                btnI.Enabled = true;
            }
            if (btnJ.Enabled == false)
            {
                btnJ.Enabled = true;
            }
            if (btnK.Enabled == false)
            {
                btnK.Enabled = true;
            }
            if (btnL.Enabled == false)
            {
                btnL.Enabled = true;
            }
            if (btnM.Enabled == false)
            {
                btnM.Enabled = true;
            }
            if (btnN.Enabled == false)
            {
                btnN.Enabled = true;
            }
            if (btnO.Enabled == false)
            {
                btnO.Enabled = true;
            }
            if (btnP.Enabled == false)
            {
                btnP.Enabled = true;
            }
            if (btnQ.Enabled == false)
            {
                btnQ.Enabled = true;
            }
            if (btnR.Enabled == false)
            {
                btnR.Enabled = true;
            }
            if (btnS.Enabled == false)
            {
                btnS.Enabled = true;
            }
            if (btnT.Enabled == false)
            {
                btnT.Enabled = true;
            }
            if (btnU.Enabled == false)
            {
                btnU.Enabled = true;
            }
            if (btnV.Enabled == false)
            {
                btnV.Enabled = true;
            }
            if (btnW.Enabled == false)
            {
                btnW.Enabled = true;
            }
            if (btnX.Enabled == false)
            {
                btnX.Enabled = true;
            }
            if (btnY.Enabled == false)
            {
                btnY.Enabled = true;
            }
            if (btnZ.Enabled == false)
            {
                btnZ.Enabled = true;
            }
        }


        // BOTONES DE LETRAS

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == "A")
            {
                letrasUsadas += "A ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnA.Enabled = false;
                ActualizarPalabraAdivinada('A');
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == "B")
            {
                letrasUsadas += "B ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnB.Enabled = false;
                ActualizarPalabraAdivinada('B');
            }
        }   

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == "C")
            {
                letrasUsadas += "C ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnC.Enabled = false;
                ActualizarPalabraAdivinada('C');
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == "D")
            {
                letrasUsadas += "D ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnD.Enabled = false;
                ActualizarPalabraAdivinada('D');
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (btnE.Text == "E")
            {
                letrasUsadas += "E ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnE.Enabled = false;
                ActualizarPalabraAdivinada('E');
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (btnF.Text == "F")
            {
                letrasUsadas += "F ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnF.Enabled = false;
                ActualizarPalabraAdivinada('F');
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (btnG.Text == "G")
            {
                letrasUsadas += "G ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnG.Enabled = false;
                ActualizarPalabraAdivinada('G');
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (btnH.Text == "H")
            {
                letrasUsadas += "H ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnH.Enabled = false;
                ActualizarPalabraAdivinada('H');
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (btnI.Text == "I")
            {
                letrasUsadas += "I ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnI.Enabled = false;
                ActualizarPalabraAdivinada('I');
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (btnJ.Text == "J")
            {
                letrasUsadas += "J ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnJ.Enabled = false;
                ActualizarPalabraAdivinada('J');
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (btnK.Text == "K")
            {
                letrasUsadas += "K ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnK.Enabled = false;
                ActualizarPalabraAdivinada('K');
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (btnL.Text == "L")
            {
                letrasUsadas += "L ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnL.Enabled = false;
                ActualizarPalabraAdivinada('L');
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (btnM.Text == "M")
            {
                letrasUsadas += "M ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnM.Enabled = false;
                ActualizarPalabraAdivinada('M');
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (btnN.Text == "N")
            {
                letrasUsadas += "N ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnN.Enabled = false;
                ActualizarPalabraAdivinada('N');
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (btnO.Text == "O")
            {
                letrasUsadas += "O ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnO.Enabled = false;
                ActualizarPalabraAdivinada('O');
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (btnP.Text == "P")
            {
                letrasUsadas += "P ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnP.Enabled = false;
                ActualizarPalabraAdivinada('P');
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (btnQ.Text == "Q")
            {
                letrasUsadas += "Q ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnQ.Enabled = false;
                ActualizarPalabraAdivinada('Q');
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (btnR.Text == "R")
            {
                letrasUsadas += "R ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnR.Enabled = false;
                ActualizarPalabraAdivinada('R');
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (btnS.Text == "S")
            {
                letrasUsadas += "S ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnS.Enabled = false;
                ActualizarPalabraAdivinada('S');
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (btnT.Text == "T")
            {
                letrasUsadas += "T ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnT.Enabled = false;
                ActualizarPalabraAdivinada('T');
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (btnU.Text == "U")
            {
                letrasUsadas += "U ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnU.Enabled = false;
                ActualizarPalabraAdivinada('U');
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (btnV.Text == "V")
            {
                letrasUsadas += "V ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnV.Enabled = false;
                ActualizarPalabraAdivinada('V');
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (btnW.Text == "W")
            {
                letrasUsadas += "W ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnW.Enabled = false;
                ActualizarPalabraAdivinada('W');
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (btnX.Text == "X")
            {
                letrasUsadas += "X ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnX.Enabled = false;
                ActualizarPalabraAdivinada('X');
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (btnY.Text == "Y")
            {
                letrasUsadas += "Y ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnY.Enabled = false;
                ActualizarPalabraAdivinada('Y');
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (btnZ.Text == "Z")
            {
                letrasUsadas += "Z ";
                lblLetrasUsadas.Text = letrasUsadas;
                btnZ.Enabled = false;
                ActualizarPalabraAdivinada('Z');
            }
        }

        private void ReiniciarInputs()
        {
            letrasUsadas = "";
            lblLetrasUsadas.Text = letrasUsadas;

            int filas = palabras.GetLength(0);
            int columnas = palabras.GetLength(1);

            int filaAleatoria = random.Next(filas);
            int columnaAleatoria = random.Next(columnas);

            palabraAleatoria = palabras[filaAleatoria, columnaAleatoria];
            lblLetrasCorrectas.Text = palabraAleatoria;

            palabraAdivinada = new string('_', palabraAleatoria.Length);
            lblLetrasCorrectas.Text = EspacioPalabraAdivinada(palabraAdivinada);
        }

        private void btnRecargarJuego_Click(object sender, EventArgs e)
        {
            InicializarTeclado();
            ReiniciarInputs();
            contadorFallos = 0;
            mtbFallos.Text = contadorFallos.ToString();
            contadorAciertos = 0;
            mtbMarcador.Text = contadorAciertos.ToString();
        }
    }
}
