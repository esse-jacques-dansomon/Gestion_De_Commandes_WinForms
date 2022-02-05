using GestionCommndesNaza.forms.client;
using GestionCommndesNaza.forms.manager;
using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using GestionCommndesNaza.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCommndesNaza
{
    class EsseJacquesDansomon
    {

        static class Program
        {
            /// <summary>
            /// Point d'entrée principal de l'application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
            }
        }
    }
}