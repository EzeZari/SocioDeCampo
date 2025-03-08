// PresupuestoDao.cs
using System;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess.SqlServer
{
    public class PresupuestoDao : ConnectionToSQL
    {
        public void CrearPresupuesto(PresupuestoCache presupuesto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO Presupuestos (categoria, monto_presupuestado, temporada, fecha_inicio, fecha_fin, notas) VALUES (@categoria, @monto_presupuestado, @temporada, @fecha_inicio, @fecha_fin, @notas)", connection))
                    {
                        command.Parameters.AddWithValue("@categoria", presupuesto.categoria);
                        command.Parameters.AddWithValue("@monto_presupuestado", presupuesto.monto_presupuestado);
                        command.Parameters.AddWithValue("@temporada", presupuesto.temporada);
                        command.Parameters.AddWithValue("@fecha_inicio", presupuesto.fecha_inicio);
                        command.Parameters.AddWithValue("@fecha_fin", presupuesto.fecha_fin);
                        command.Parameters.AddWithValue("@notas", presupuesto.notas ?? (object)DBNull.Value);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear presupuesto: " + ex.Message);
                throw;
            }
        }

        public DataTable MostrarPresupuestos()
        {
            var tabla = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Presupuestos ORDER BY temporada DESC, categoria", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar presupuestos: " + ex.Message);
                throw;
            }
            return tabla;
        }

        public DataTable MostrarPresupuestosPorTemporada(string temporada)
        {
            var tabla = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Presupuestos WHERE temporada = @temporada ORDER BY categoria", connection))
                    {
                        command.Parameters.AddWithValue("@temporada", temporada);
                        using (var reader = command.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar presupuestos por temporada: " + ex.Message);
                throw;
            }
            return tabla;
        }

        public void EditarPresupuesto(PresupuestoCache presupuesto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("UPDATE Presupuestos SET categoria = @categoria, monto_presupuestado = @monto_presupuestado, temporada = @temporada, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, notas = @notas WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", presupuesto.id);
                        command.Parameters.AddWithValue("@categoria", presupuesto.categoria);
                        command.Parameters.AddWithValue("@monto_presupuestado", presupuesto.monto_presupuestado);
                        command.Parameters.AddWithValue("@temporada", presupuesto.temporada);
                        command.Parameters.AddWithValue("@fecha_inicio", presupuesto.fecha_inicio);
                        command.Parameters.AddWithValue("@fecha_fin", presupuesto.fecha_fin);
                        command.Parameters.AddWithValue("@notas", presupuesto.notas ?? (object)DBNull.Value);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar presupuesto: " + ex.Message);
                throw;
            }
        }

        public void EliminarPresupuesto(int id)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("DELETE FROM Presupuestos WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar presupuesto: " + ex.Message);
                throw;
            }
        }

        public DataTable ObtenerComparativoPresupuestoVsGasto(string temporada)
        {
            var tabla = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand(@"
           SELECT 
    p.categoria,
    p.monto_presupuestado,
    COALESCE(SUM(g.cantidad), 0) AS gasto_actual,
    (p.monto_presupuestado - COALESCE(SUM(g.cantidad), 0)) AS diferencia,
    CASE 
        WHEN p.monto_presupuestado = 0 THEN 0
        ELSE (COALESCE(SUM(g.cantidad), 0) / p.monto_presupuestado) * 100 
    END AS porcentaje_usado
FROM 
    Presupuestos p
LEFT JOIN 
    gastos g ON p.categoria = g.tipo_de_gasto
WHERE 
    p.temporada = '2025-2026'
GROUP BY 
    p.categoria, p.monto_presupuestado
ORDER BY 
    p.categoria", connection))
                    {
                        command.Parameters.AddWithValue("@temporada", temporada);
                        using (var reader = command.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener comparativo: " + ex.Message);
                throw;
            }
            return tabla;
        }
    }
}