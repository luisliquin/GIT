using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task01 {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Task T1 = new Task(() => MessageBox.Show("mensaje"));
            T1.Start();

            Task T2 = new Task(() => addMessage("Ejecutando tarea 2",5));
            T2.Start();

            Task T3 = new Task(() => addMessage("Ejecutando tarea 3",5));
            T3.Start();

            Task T4 = new Task(() => addMessage("Ejecutando tarea 4",5));
            T4.Start();

            addMessage("Final del hilo principal",0);
        }

        void addMessage(string message, int seconds) {
            Thread.Sleep(1000*seconds);

            var hilo = Thread.CurrentThread.ManagedThreadId;

            this.Dispatcher.Invoke(() => {
                lblMessage.Content+=$"Mensaje: {message}, "+
                                    $"Hola Actual: {hilo}\n";
            });            
        }
    }
}