using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IEmpleadoService _empleadoService;

        [ObservableProperty]
        private ObservableCollection<Empleado> _empleados = new();

        [ObservableProperty]
        private List<string> _departamentos = new() { "Backend","Frontend","RRHH","Finanzas","Marketing" };

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AgregarEmpleadoCommand))]
        private String _nuevoNombre = string.Empty;
        [ObservableProperty]
        private String _nuevoDepartamento = "Backend";
        [ObservableProperty]
        private decimal _nuevoSalario = 18000;
        [ObservableProperty]
        private bool _nuevoActivo;
        [ObservableProperty]
        private Empleado? _empleadoSeleccionado;




        public MainViewModel(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
            CargarDatos();
        }

        private void CargarDatos()
        {
            var datos = _empleadoService.ObtenerEmpleadosMockup();
            Empleados = new ObservableCollection<Empleado>(datos);
        }

        private bool CanAgregar => !string.IsNullOrWhiteSpace(NuevoNombre);

        [RelayCommand]
        public void AgregarEmpleado()
        {
            var nuevo = new Empleado
            {
                Id = Empleados.Count + 1,
                Nombre = NuevoNombre,
                Departamento = NuevoDepartamento,
                Salario = NuevoSalario,
                JornadaCompleta = NuevoActivo

            };

            Empleados.Add(nuevo);

            NuevoNombre = string.Empty;
        }
    }
}
