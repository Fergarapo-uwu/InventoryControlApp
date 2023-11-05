using System;
using AlmacenDataContext;
using AlmacenSQLiteEntities;
public static partial class CrudFuntions
{
    // Función para el READ de la tabla almacenista
    static void Read_Al()
    {
        using (Almacen bd = new())
        {
            if (bd.Almacenistas is null || (!bd.Almacenistas.Any()))
            {
                WriteLine("No se encontraron almacenistas");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-10}|{6,-10}",
                "AlmacenistaId", "Nombre", "Apellido Paterno", "ApellidoMaterno", "Correo", "PlantelId", "UsuarioId");

                foreach (var almacenista in bd.Almacenistas)
                {
                    Write($"{almacenista.AlmacenistaId,-13}|{almacenista.Nombre,-20}|{almacenista.ApellidoPaterno,-20}|");
                    WriteLine($"{almacenista.ApellidoMaterno,-20}|{almacenista.Correo,-20}|{almacenista.PlantelId,-10}|{almacenista.UsuarioId}");
                }
            }
        }
    }

    // Función para el READ de la tabla categorías
    static void Read_Cat()
    {
        using (Almacen bd = new())
        {
            if (bd.Categorias is null || (!bd.Categorias.Any()))
            {
                WriteLine("No se encontraron categorías");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}",
                "CategoriaId", "Nombre", "Descripcion", "Materiales");

                foreach (var cat in bd.Categorias)
                {
                    WriteLine($"{cat.CategoriaId,-13}|{cat.Nombre,-20}|{cat.Descripcion,-20}|{cat.Materiales}");
                }
            }
        }
    }

    // Función para el READ de la tabla coordinadores
    static void Read_Co()
    {
        using (Almacen bd = new())
        {
            if (bd.Coordinadores is null || (!bd.Coordinadores.Any()))
            {
                WriteLine("No se encontraron coordinadores");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-10}|{6,-10}",
                "CoordinadorId", "Nombre", "ApellidoPaterno", "ApellidoMaterno", "Correo", "PlantelId", "UsuarioId");

                foreach (var cord in bd.Coordinadores)
                {
                    WriteLine($"{cord.CoordinadorId,-13}|{cord.Nombre,-20}|{cord.ApellidoPaterno,-20}|{cord.ApellidoMaterno,-20}|{cord.Correo,-20}|{cord.PlantelId,-10}|{cord.UsuarioId}");
                }
            }
        }
    }

    // Función para el READ de la tabla descripciones de pedidos
    static void Read_DescPed()
    {
        using (Almacen bd = new())
        {
            if (bd.DescPedidos is null || (!bd.DescPedidos.Any()))
            {
                WriteLine("No se encontraron descripciones de pedidos");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}",
                "DescPedidoId", "Cantidad", "PedidoId", "MaterialId");

                foreach (var desc in bd.DescPedidos)
                {
                    WriteLine($"{desc.DescPedidoId,-13}|{desc.Cantidad,-20}|{desc.PedidoId,-20}|{desc.MaterialId}");
                }
            }
        }
    }

    // Función para el READ de la tabla estudiantes
    static void Read_Es()
    {
        using (Almacen bd = new())
        {
            if (bd.Estudiantes is null || (!bd.Estudiantes.Any()))
            {
                WriteLine("No se encontraron estudiantes");
            }
            else
            {
                WriteLine("{0,-12}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-10}|{6,-10}|{7,-10}|{8,-5}|{9,-15}",
                "EstudianteId", "Nombre", "Apellido Paterno", "ApellidoMaterno", "Correo", "PlantelId", "UsuarioID", "SemestreId", "GrupoId", "Adeudo");

                foreach (var es in bd.Estudiantes)
                {
                    WriteLine($"{es.EstudianteId,-12}|{es.Nombre,-20}|{es.ApellidoPaterno,-20}|{es.ApellidoMaterno,-20}|{es.Correo,-20}|{es.PlantelId,-10}|{es.UsuarioId,-10}|{es.SemestreId,-10}|{es.GrupoId,-7}|{es.Adeudo}");
                }
            }
        }
    }

    // Función para el READ de la tabla docentes
    static void Read_Doc()
    {
        using (Almacen bd = new())
        {
            if (bd.Docentes is null || (!bd.Docentes.Any()))
            {
                WriteLine("No se encontraron docentes");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-10}|{6,-10}",
                "DocenteId", "Nombre", "Apellido Paterno", "ApellidoMaterno", "Correo", "PlantelId", "UsuarioId");

                foreach (var dc in bd.Docentes)
                {
                    WriteLine($"{dc.DocenteId,-10}|{dc.Nombre,-20}|{dc.ApellidoPaterno,-20}|{dc.ApellidoMaterno,-20}|{dc.Correo,-20}|{dc.PlantelId,-10}|{dc.UsuarioId}");
                }
            }
        }
    }

    // Función para el READ de la tabla grupos
    static void Read_Gr()
    {
        using (Almacen bd = new())
        {
            if (bd.Grupos is null || (!bd.Grupos.Any()))
            {
                WriteLine("No se encontraron grupos");
            }
            else
            {
                WriteLine("{0,-10}|{1}", "GrupoId", "Nombre");

                foreach (var gr in bd.Grupos)
                {
                    WriteLine($"{gr.GrupoId,-10}|{gr.Nombre}");
                }
            }
        }
    }

    // Función para el READ de la tabla laboratorios
    static void Read_Lab()
    {
        using (Almacen bd = new())
        {
            if (bd.Laboratorios is null || (!bd.Laboratorios.Any()))
            {
                WriteLine("No se encontraron laboratorios");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2}",
                "LaboratorioId", "Nombre", "Descripcion");

                foreach (var lab in bd.Laboratorios)
                {
                    WriteLine($"{lab.LaboratorioId,-10}|{lab.Nombre,-20}|{lab.Descripcion}");
                }
            }
        }
    }

    // Función para el READ de la tabla mantenimientos
    static void Read_Mant()
    {
        using (Almacen bd = new())
        {
            if (bd.Mantenimientos is null || (!bd.Mantenimientos.Any()))
            {
                WriteLine("No se encontraron mantenimientos");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2}",
                "MantenimientoId", "Nombre", "Descripcion");
                foreach (var man in bd.Mantenimientos)
                {
                    WriteLine($"{man.MantenimientoId,-10}|{man.Nombre,-20}|{man.Descripcion}");
                }
            }
        }
    }

    // Función para el READ de la tabla marcas
    static void Read_Mar()
    {
        using (Almacen bd = new())
        {
            if (bd.Marcas is null || (!bd.Marcas.Any()))
            {
                WriteLine("No se encontraron marcas");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2}",
                "MarcaId", "Nombre", "Descripcion");
                foreach (var mar in bd.Marcas)
                {
                    WriteLine($"{mar.MarcaId,-10}|{mar.Nombre,-20}|{mar.Descripcion}");
                }
            }
        }
    }

    // Función para el READ de la tabla materiales
    static void Read_Mat()
    {
        using (Almacen bd = new())
        {
            if (bd.Materiales is null || (!bd.Materiales.Any()))
            {
                WriteLine("No se encontraron materiales");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-15}|{3}",
                "MaterialId", "ModeloId", "Descripcion", "YearEntrada");
                foreach (var mat in bd.Materiales)
                {
                    WriteLine($"{mat.MaterialId,-10}|{mat.ModeloId,-20}|{mat.Descripcion,15}|{mat.YearEntrada}");
                }
            }
        }
    }

    // Función para el READ de la tabla modelos
    static void Read_Mod()
    {
        using (Almacen bd = new())
        {
            if (bd.Modelos is null || (!bd.Modelos.Any()))
            {
                WriteLine("No se encontraron modelos");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2}",
                "ModeloId", "Nombre", "Descripcion");
                foreach (var mod in bd.Modelos)
                {
                    WriteLine($"{mod.ModeloId,-10}|{mod.Nombre,-20}|{mod.Descripcion}");
                }
            }
        }
    }

    // Función para el READ de la tabla pedidos
    static void Read_Ped()
    {
        using (Almacen bd = new())
        {
            if (bd.Pedidos is null || (!bd.Pedidos.Any()))
            {
                WriteLine("No se encontraron pedidos");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-10}|{6,-10}",
                "PedidoId", "Fecha", "LaboratorioId", "HoraEntrega", "HoraDevolucion", "EstudianteId", "DocenteId");
                foreach (var ped in bd.Pedidos)
                {
                    WriteLine($"{ped.PedidoId,-13}|{ped.Fecha,-20}|{ped.LaboratorioId,-20}|{ped.HoraEntrega,-20}|{ped.HoraDevolucion,-20}|{ped.EstudianteId,-10}|{ped.DocenteId}");
                }
            }
        }
    }

    // Función para el READ de la tabla planteles
    static void Read_Plan()
    {
        using (Almacen bd = new())
        {
            if (bd.Planteles is null || (!bd.Planteles.Any()))
            {
                WriteLine("No se encontraron planteles");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-82}|{3}",
                    "PlantelId", "Nombre", "Direccion", "Telefono");
                foreach (var pl in bd.Planteles)
                {
                    WriteLine($"{pl.PlantelId,-10}|{pl.Nombre,-20}|{pl.Direccion,-82}|{pl.Telefono}");
                }
            }
        }
    }

    // Función para el READ de la tabla reportes de mantenimiento
    static void Read_Reporte()
    {
        using (Almacen bd = new())
        {
            if (bd.ReporteMantenimientos is null || (!bd.ReporteMantenimientos.Any()))
            {
                WriteLine("No se encontraron reportes de mantenimiento");
            }
            else
            {
                WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}",
                "ReporteMantenimientoId", "Fecha", "MantenimientoId", "MaterialId");
                foreach (var rp in bd.ReporteMantenimientos)
                {
                    WriteLine($"{rp.ReporteMantenimientoId,-13}|{rp.Fecha,-20}|{rp.MantenimientoId,-20}|{rp.MaterialId,-20}");
                }
            }
        }
    }

    // Función para el READ de la tabla semestres
    static void Read_Semestre()
    {
        using (Almacen bd = new())
        {
            if (bd.Semestres is null || (!bd.Semestres.Any()))
            {
                WriteLine("No se encontraron semestres");
            }
            else
            {
                WriteLine("{0,-10}|{1}",
                "SemestreId", "Numero");
                foreach (var sm in bd.Semestres)
                {
                    WriteLine($"{sm.SemestreId,-10}|{sm.Numero}");
                }
            }
        }
    }

    // Función para el READ de la tabla usuarios
    static void Read_Usuario()
    {
        using (Almacen bd = new())
        {
            if (bd.Usuarios is null || (!bd.Usuarios.Any()))
            {
                WriteLine("No se encontraron usuarios");
            }
            WriteLine("{0,-10}|{1,-20}|{2}",
            "UsuarioId", "Usuario1", "Password");
            foreach (var us in bd.Usuarios)
            {
                WriteLine($"{us.UsuarioId,-10}|{us.Usuario1,-20}|{us.Password}");
            }
        }
    }
}

