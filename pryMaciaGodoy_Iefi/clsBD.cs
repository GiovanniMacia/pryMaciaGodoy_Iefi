using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMaciaGodoy_Iefi
{
    internal class clsBD
    {
        public string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=LabIefi ;Trusted_Connection=True;";


        #region Conexión y Utilidades
        private SqlConnection AbrirConexion()
        {
            var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        private void MostrarError(string contexto, Exception ex)
        {
            MessageBox.Show($"Ocurrió un error al {contexto}.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Gestión de Usuarios
        public void ObtenerUsuarios(DataGridView grilla)
        {
            const string sql = @"
        SELECT u.Id, u.Nombre, u.Contraseña, u.Correo, r.Nombre AS Rol 
        FROM Usuarios u 
        INNER JOIN Roles r ON u.RolId = r.Id";

            try
            {
                using (var conn = AbrirConexion())
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var tabla = new DataTable();
                    adapter.Fill(tabla);
                    grilla.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MostrarError("usuarios", ex);
            }
        }

        public void RegistrarUsuario(clsUsuario usuario)
        {
            const string sql = @"
        INSERT INTO Usuarios (Nombre, Contraseña, Correo, RolId) 
        VALUES (@Nombre, @Contraseña, @Correo, @Rol)";

            try
            {
                using (var conn = AbrirConexion())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = usuario.Nombre;
                    cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = usuario.Contraseña;
                    cmd.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = usuario.Correo;
                    cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = usuario.RolId;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MostrarError("registrar usuario", ex);
            }
        }

        public void ActualizarUsuario(clsUsuario usuario)
        {
            const string sql = @"
        UPDATE Usuarios 
        SET Nombre = @Nombre, Contraseña = @Contraseña, Correo = @Correo, RolId = @RolId 
        WHERE Id = @Id";

            try
            {
                using (var conn = AbrirConexion())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = usuario.Nombre;
                    cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = usuario.Contraseña;
                    cmd.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = usuario.Correo;
                    cmd.Parameters.Add("@RolId", SqlDbType.Int).Value = usuario.RolId;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = usuario.Id;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado correctamente.", "Actualización");
                }
            }
            catch (Exception ex)
            {
                MostrarError("actualizar usuario", ex);
            }
        }

        public void EliminarUsuario(int id)
        {
            const string sql = "DELETE FROM Usuarios WHERE Id = @Id";

            try
            {
                using (var conn = AbrirConexion())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado.", "Confirmación");
                }
            }
            catch (Exception ex)
            {
                MostrarError("eliminar usuario", ex);
            }
        }

        public void BuscarUsuarioPorNombre(DataGridView grilla, string nombre)
        {
            const string sql = "SELECT Id, Nombre, Correo FROM Usuarios WHERE Nombre LIKE @Nombre";

            try
            {
                using (var conn = AbrirConexion())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = "%" + nombre + "%";

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var tabla = new DataTable();
                        adapter.Fill(tabla);

                        if (tabla.Rows.Count == 0 && nombre.Length > 2)
                            MessageBox.Show("No se encontró el usuario.", "Aviso");

                        grilla.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("buscar usuario", ex);
            }
        }

        public bool AutenticarUsuario(clsUsuario usuario)
        {
            const string sql = "SELECT RolId FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";

            try
            {
                using (var conn = AbrirConexion())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = usuario.Nombre;
                    cmd.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = usuario.Contraseña;

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        usuario.RolId = Convert.ToInt32(resultado);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("autenticación", ex);
                return false;
            }
        }

        public int ObtenerIdUsuarioPorNombre(string nombreUsuario)
        {
            int id = 0;
            try
            {
                using (var conn = AbrirConexion())
                {
                    string query = "SELECT Id FROM Usuarios WHERE Nombre = @Nombre";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                        var res = cmd.ExecuteScalar();
                        if (res != null)
                        {
                            id = Convert.ToInt32(res);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("obtener ID de usuario", ex);
            }
            return id;
        }
        #endregion

        #region Gestión de Sesiones
        public void GuardarSesion(clsSesion sesion)
        {
            const string sql = @"
        INSERT INTO Sesiones (IdUsuario, FechaInicio, HoraInicio, HoraFin) 
        VALUES (@IdUsuario, @FechaInicio, @HoraInicio, @HoraFin)";

            try
            {
                using (var conn = AbrirConexion())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = sesion.IdUsuario;
                    cmd.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = sesion.FechaInicio;
                    cmd.Parameters.Add("@HoraInicio", SqlDbType.Time).Value = sesion.HoraInicio.TimeOfDay;
                    cmd.Parameters.Add("@HoraFin", SqlDbType.Time).Value = sesion.HoraFin.TimeOfDay;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MostrarError("guardar sesión", ex);
            }
        }

        public void ListarSesiones(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT u.Nombre, s.FechaInicio, s.HoraInicio, s.HoraFin, s.TiempoTranscurrido " +
                                   "FROM Sesiones s INNER JOIN Usuarios u ON s.IdUsuario = u.Id " +
                                   "ORDER BY s.FechaInicio DESC, s.HoraInicio DESC;";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Grilla.DataSource = tabla;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudieron cargar las sesiones correctamente. Revise su conexión o intente más tarde. Detalles del error: {error.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Gestión de Tareas
        public void GuardarTarea(clsTarea tarea)
        {
            const string sql = @"
        INSERT INTO Tareas 
        (IdUsuario, IdTipoTarea, Fecha, IdLugar, Comentario, Insumo, Estudio, Vacacion, ReclamoSalario, ReclamoRecibo)
        VALUES 
        (@usuario, @tipo, @fecha, @lugar, @comentario, @insumo, @estudio, @vacacion, @salario, @recibo)";

            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@usuario", tarea.IdUsuario);
                cmd.Parameters.AddWithValue("@tipo", tarea.IdTipoTarea);
                cmd.Parameters.AddWithValue("@fecha", tarea.Fecha);
                cmd.Parameters.AddWithValue("@lugar", (object)tarea.IdLugar ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@comentario", tarea.Comentario ?? "");
                cmd.Parameters.AddWithValue("@insumo", tarea.Insumo);
                cmd.Parameters.AddWithValue("@estudio", tarea.Estudio);
                cmd.Parameters.AddWithValue("@vacacion", tarea.Vacacion);
                cmd.Parameters.AddWithValue("@salario", tarea.ReclamoSalario);
                cmd.Parameters.AddWithValue("@recibo", tarea.ReclamoRecibo);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la tarea: " + ex.Message);
                }
            }
        }

        public void Listar_Tareas(DataGridView grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT t.Id, t.Fecha, tt.Nombre AS Tarea, l.Nombre AS Lugar, " +
                                   "t.Insumo, t.Estudio, t.Vacacion, t.ReclamoSalario AS Salario, t.ReclamoRecibo AS Recibo, t.Comentario AS Comentarios " +
                                   "FROM Tareas t " +
                                   "INNER JOIN TiposTarea tt ON t.IdTipoTarea = tt.Id " +
                                   "LEFT JOIN Lugares l ON t.IdLugar = l.Id " +
                                   "ORDER BY t.Fecha DESC;";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    grilla.DataSource = tabla;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al listar las tareas: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarporTarea(DataGridView grilla, string texto)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT t.Id, t.Fecha, tt.Nombre AS Tarea, l.Nombre AS Lugar, " +
                                   "t.Insumo, t.Estudio, t.Vacacion, t.ReclamoSalario AS Salario, " +
                                   "t.ReclamoRecibo AS Recibo, t.Comentario AS Comentarios " +
                                   "FROM Tareas t " +
                                   "INNER JOIN TiposTarea tt ON t.IdTipoTarea = tt.Id " +
                                   "LEFT JOIN Lugares l ON t.IdLugar = l.Id " +
                                   "WHERE tt.Nombre LIKE @texto " +
                                   "ORDER BY t.Fecha DESC;";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@texto", "%" + texto + "%");

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    grilla.DataSource = tabla;

                    if (tabla.Rows.Count == 0 && texto.Length >= 3)
                    {
                        MessageBox.Show("No se encontró ninguna tarea con ese nombre.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar tareas: " + ex.Message);
            }
        }
        #endregion

        #region Tipos de Tarea y Lugares
        public void CargarTiposTarea(ComboBox combo)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                string query = "SELECT Id, Nombre FROM TiposTarea";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo.DataSource = dt;
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Id";
                combo.SelectedIndex = -1;
            }
        }

        public void CargarLugares(ComboBox combo)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                string query = "SELECT Id, Nombre FROM Lugares";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo.DataSource = dt;
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Id";
                combo.SelectedIndex = -1;
            }
        }

        public void Agregar_TipoTarea(clsTarea tarea)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "INSERT INTO TiposTarea (Nombre) VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Nombre", tarea.Comentario);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Agregar_Lugar(string nombreLugar)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "INSERT INTO Lugares (Nombre) VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Nombre", nombreLugar);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Modificar_TipoTarea(int id, string nuevoNombre)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE TiposTarea SET Nombre = @Nombre WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar_TipoTarea(int id)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM TiposTarea WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Modificar_Lugar(int id, string nuevoNombre)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Lugares SET Nombre = @Nombre WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar_Lugar(int id)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Lugares WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool TipoTareaEnUso(int id)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT COUNT(*) FROM Tareas WHERE IdTipoTarea = @Id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                int cantidad = (int)cmd.ExecuteScalar();
                return cantidad > 0;
            }
        }

        public bool LugarEnUso(int id)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT COUNT(*) FROM Tareas WHERE IdLugar = @Id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                int cantidad = (int)cmd.ExecuteScalar();
                return cantidad > 0;
            }
        }
        #endregion

    }
}
