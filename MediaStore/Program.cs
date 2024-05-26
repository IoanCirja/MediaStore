/***************************************************************************
 *                                                                         *
 *  Fisier:      Program.cs                                                *
 *               Func?ionalitate ad?ugat? de Cîrja Ioan                    *
 *                                           Mih?luc? M?d?lina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Main-ul Programului                                        *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/

using MediaStore;

namespace MediaStore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}