namespace ClubDeportivoLogin
{
    public static class ABMActividadesConfig
    {
        public static FormABMBase.ConfigABM ObtenerConfig(string usuario)
        {
            return new FormABMBase.ConfigABM
            {
                TituloVentana = "ABM de Actividades",
                Titulo = "Maestro de Actividades",
                Subtitulo = "Asistente de A.B.M.",
                Ayuda1 = "Este asistente le ayudará a consultar, agregar, modificar o borrar una Actividad del Club de la tabla, y realizar cambios en el \"Maestro de Actividades\".",
                Ayuda2 = "Ingrese la Actividad que desea consultar, agregar, modificar o borrar y presione \"Enter\" o botón \"Siguiente\" para continuar.",
                EtiquetaCampo = "ACTIVIDAD: ",
                Icono = Properties.Resources.ActividadIcon,
                Validacion = nombre => !string.IsNullOrWhiteSpace(nombre),
                AccionSiguiente = nombre =>
                {
                    string nombreMayus = nombre.Trim().ToUpper();
                    int? idActividad = null;

                    using (var conn = new Conexion().Conectar())
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT id FROM actividad WHERE UPPER(nombre) = @nombre", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreMayus);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            idActividad = Convert.ToInt32(result);
                    }

                    FormRegistrarActividad form;
                    if (idActividad.HasValue)
                        form = new FormRegistrarActividad(idActividad.Value);
                    else
                    {
                        form = new FormRegistrarActividad();
                        form.SetNombreActividad(nombreMayus);
                    }
                    form.ShowDialog();
                },

                // AUTOCOMPLETADO PARA ACTIVIDADES
                ObtenerSugerencias = filtro =>
                {
                    if (string.IsNullOrWhiteSpace(filtro))
                        return Enumerable.Empty<string>();

                    try
                    {
                        using (var conn = new Conexion().Conectar())
                        {
                            var query = "SELECT nombre FROM actividad " +
                                        "WHERE UPPER(nombre) LIKE @filtro " +
                                        "ORDER BY nombre " +
                                        "LIMIT 10";

                            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@filtro", $"%{filtro.ToUpper()}%");

                                var sugerencias = new List<string>();
                                using (var reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        sugerencias.Add(reader["nombre"].ToString());
                                    }
                                }
                                return sugerencias;
                            }
                        }
                    }
                    catch
                    {
                        return Enumerable.Empty<string>();
                    }
                }

            };
        }
    }
}
