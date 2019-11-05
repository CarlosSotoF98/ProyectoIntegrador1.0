using System;
//test
public class ModificarRegistro
{
	public ModificarRegistro()
	{
        int ID;
        string tabla, ape, nom, admi;
        switch (tabla)
        {
            case Dentista:
                string sqlIns = "UPDATE Dentista SET nombre_dent=@nom ,apellido_dent=@ape WHERE id_dentista =@ID";
                db.Open();
                try
                {
                    SqlCommand cmdIns = new SqlCommand(sqlIns, db.Connection);
                    cmdIns.Parameters.Add("@id", ID);
                    cmdIns.Parameters.Add("@nom", nom);
                    cmdIns.Parameters.Add("@ape", ape);
                    cmdIns.ExecuteNonQuery();
                    cmdIns.Dispose();
                    cmdIns = null;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString(), ex);
                }
                finally
                {
                    db.Close();
                }
                break;

            case Asistente:
                string sqlIns = "UPDATE Asistente SET nombre_asis=@nom ,apellido_asis=@ape ,id_admi=@admi WHERE id_asis =@ID";
                db.Open();
                try
                {
                    SqlCommand cmdIns = new SqlCommand(sqlIns, db.Connection);
                    cmdIns.Parameters.Add("@id", ID);
                    cmdIns.Parameters.Add("@nom", nom);
                    cmdIns.Parameters.Add("@ape", ape);
                    cmdIns.Parameters.Add("@admi", admi);
                    cmdIns.ExecuteNonQuery();
                    cmdIns.Dispose();
                    cmdIns = null;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString(), ex);
                }
                finally
                {
                    db.Close();
                }
                break;

            case Cliente:
                string sqlIns = "UPDATE Cliente SET nombre_cli=@nom ,apellido_cli=@ape , WHERE id_cleinte =@ID";
                db.Open();
                try
                {
                    SqlCommand cmdIns = new SqlCommand(sqlIns, db.Connection);
                    cmdIns.Parameters.Add("@id", ID);
                    cmdIns.Parameters.Add("@nom", nom);
                    cmdIns.Parameters.Add("@ape", ape);
                    cmdIns.ExecuteNonQuery();
                    cmdIns.Dispose();
                    cmdIns = null;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString(), ex);
                }
                finally
                {
                    db.Close();
                }
                break;

        }

    }
}
