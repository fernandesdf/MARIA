using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using Maria_teste1_;

namespace BusinessLogicLayer
{
    public class BLL 
    {
        public class Administrador
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Administrador", null);
            }

            static public DataTable queryAdmin(string userName)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@User", userName)
                };
                return dal.executarReader("select * from Administrador where [User]=@User", sqlParams);
            }

            static public int insertAdministrador(string user, string pass, string nome, string telef_pessoal, string telef_casa, string telef_emprego, string morada, string morada_emprego, string grau_parentesco, string cod_postal)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@User", user),
                new SqlParameter("@Pass", pass),
                new SqlParameter("@Nome", nome),
                new SqlParameter("@Telef_Pessoal", telef_pessoal),
                new SqlParameter("@Telef_Casa", telef_casa),
                new SqlParameter("@Telef_Emprego", telef_emprego),
                new SqlParameter("@Morada", morada),
                new SqlParameter("@Morada_Emprego", morada_emprego),
                new SqlParameter("@Grau_Parentesco", grau_parentesco),
                new SqlParameter("@Cod_postal", cod_postal)
        
           };
                return dal.executarNonQuery("INSERT into [Administrador] ([User],Pass,Nome,Telef_Pessoal,Telef_Casa,Telef_Emprego,Morada,Morada_Emprego,Grau_Parentesco,Cod_postal) VALUES(@User,@Pass,@Nome,@Telef_Pessoal,@Telef_Casa,@Telef_Emprego,@Morada,@Morada_Emprego,@Grau_Parentesco,@Cod_postal)", sqlParams);
            }

            static public DataTable queryLogin(string userName, string pass)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@User", userName),
                new SqlParameter("@Pass", pass)
                };
                return dal.executarReader("select * from Administrador where [User]=@User and Pass=@Pass", sqlParams);
            }

            static public int updateEditar(string userName, string nome, string t_pessoal, string t_casa, string t_emp, string morada, string morada_emp, string grau, string cod_postal)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams=new SqlParameter[]{
                    new SqlParameter("@User", userName),
                    new SqlParameter("@Nome", nome),
                    new SqlParameter("@Telef_Pessoal", t_pessoal),
                    new SqlParameter("@Telef_Casa", t_casa),
                    new SqlParameter("@Telef_Emprego", t_emp),
                    new SqlParameter("@Morada", morada),
                    new SqlParameter("@Morada_Emprego", morada_emp),
                    new SqlParameter("@Grau_Parentesco", grau),
                    new SqlParameter("@Cod_postal", cod_postal)

                };
                    return dal.executarNonQuery("update Administrador set Nome=@Nome, Telef_Pessoal=@Telef_Pessoal, Telef_Casa=@Telef_Casa, Telef_Emprego=@Telef_Emprego, Morada=@Morada, Morada_Emprego=@Morada_Emprego, Grau_Parentesco=@Grau_Parentesco, Cod_postal=@Cod_postal where [User]=@User", sqlparams);               
            }




            static public DataTable queryCliente_Like(String nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome + "%")
                };
                return dal.executarReader("select * from Clientes where Nome like @nome or Contacto like @nome", sqlParams);
            }


        }

        public class Primeira_sessao
        {
            static public DataTable queryCliente()
            {
                DAL dal = new DAL();
                
                return dal.executarReader("select * from Primeira_sessao where Id=1", null);
            }
            static public int updateCliente(bool primeira)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@primeira", primeira),
                 

                };
                return dal.executarNonQuery("update [Primeira_sessao] set [primeira]=@primeira where [Id]=1", sqlParams);
            }

        }

        public class Doente
        {
            static public DataTable LoadDoente()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Doente", null);
            }

            static public DataTable LoadDoenca()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Doencas_extras", null);
            }

            static public int insertDoente(string nome, string morada, string grau_doenca,  string sintomas, string tipo_sangue)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@grau_doenca", grau_doenca),
                new SqlParameter("@sintomas", sintomas),
                new SqlParameter("@tipo_sangue", tipo_sangue)
                
           };
                return dal.executarNonQuery("INSERT into [Doente] (nome,morada,grau_doenca,sintomas,tipo_sangue) VALUES(@nome,@morada,@grau_doenca,@sintomas,@tipo_sangue)", sqlParams);
            }

            static public int insertDoencas_extras(string doenca)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@doenca", doenca)
                
           };
                return dal.executarNonQuery("INSERT into [Doencas_extras] (doenca) VALUES(@doenca)", sqlParams);
            }

            static public int insertMedicacao(int id_doenca, string medicamento)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_doenca", id_doenca),
                new SqlParameter("@medicamento", medicamento)
           };
                return dal.executarNonQuery("INSERT into [Medicacao] (id_doenca,medicamento) VALUES(@id_doenca,@medicamento)", sqlParams);
            }

            static public DataTable queryDoenca(string doenca)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@doenca", doenca)
                };
                return dal.executarReader("select * from Doencas_extras where doenca=@doenca", sqlParams);
            }

            static public DataTable queryMedicacao(int id_doenca, string medicamento)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_doenca", id_doenca),
                new SqlParameter("@medicamento", medicamento)
                };
                return dal.executarReader("select * from [Medicacao] where id_doenca=@id_doenca and medicamento=@medicamento", sqlParams);
            }

            static public DataTable queryMedicamento(int id_doenca)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_doenca", id_doenca)
                };
                return dal.executarReader("select * from Medicacao where id_doenca=@id_doenca", sqlParams);
            }

            static public DataTable queryMedicamento1(int medicamento)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@medicamento", medicamento)
                };
                return dal.executarReader("select * from Medicacao where medicamento=@medicamento", sqlParams);
            }

            static public int updateDoente(string nome, string morada, string grau_doenca, string sintomas, string tipo_sangue)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@grau_doenca", grau_doenca),
                new SqlParameter("@sintomas", sintomas),
                new SqlParameter("@tipo_sangue", tipo_sangue)
                
           };
                return dal.executarNonQuery("Update [Doente] set nome=@nome, morada=@morada, grau_doenca=@grau_doenca, sintomas=@sintomas, tipo_sangue=@tipo_sangue", sqlParams);
            }

            static public int deleteDoenca(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
               
            };
                return dal.executarNonQuery("Delete From Doencas_extras Where [id]=@id", sqlParams);
            }

            static public int deleteMedicacao(int id_doenca)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_doenca", id_doenca),
               
            };
                return dal.executarNonQuery("Delete From Medicacao Where [id_doenca]=@id_doenca", sqlParams);
            }

            static public int deleteMedicamento(int id_doenca, string medicamento)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_doenca", id_doenca),
                new SqlParameter("@medicamento", medicamento),
               
            };
                return dal.executarNonQuery("Delete From Medicacao Where [id_doenca]=@id_doenca and medicamento=@medicamento", sqlParams);
            }

        }    

        public class Medicos
        {
            static public DataTable LoadMed_fam()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Medico_familia", null);
            }

            static public DataTable LoadMed_esp()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Medico_especialidade", null);
            }

            static public int insertMedico_fam(string nome, string morada, string telefone, string morada_centro, string telefone_centro)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@telefone", telefone),
                new SqlParameter("@morada_centro", morada_centro),
                new SqlParameter("@telefone_centro", telefone_centro)
           };
                return dal.executarNonQuery("INSERT into [Medico_familia] (nome,morada,telefone,morada_centro,telefone_centro) VALUES(@nome,@morada,@telefone,@morada_centro,@telefone_centro)", sqlParams);
            }

            static public int insertMedico_esp(string nome, string morada, string telefone, string morada_centro, string telefone_centro)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@telefone", telefone),
                new SqlParameter("@morada_centro", morada_centro),
                new SqlParameter("@telefone_centro", telefone_centro)
           };
                return dal.executarNonQuery("INSERT into [Medico_especialidade] (nome,morada,telefone,morada_centro,telefone_centro) VALUES(@nome,@morada,@telefone,@morada_centro,@telefone_centro)", sqlParams);
            }

            static public int updateMedico_fam(string nome, string morada, string telefone, string morada_centro, string telefone_centro)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@telefone", telefone),
                new SqlParameter("@morada_centro", morada_centro),
                new SqlParameter("@telefone_centro", telefone_centro)
           };
                return dal.executarNonQuery("Update [Medico_familia] set nome=@nome, morada=@morada, telefone=@telefone, morada_centro=@morada_centro, telefone_centro=@telefone_centro", sqlParams);
            }

            static public int updateMedico_esp(string nome, string morada, string telefone, string morada_centro, string telefone_centro)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@telefone", telefone),
                new SqlParameter("@morada_centro", morada_centro),
                new SqlParameter("@telefone_centro", telefone_centro)
           };
                return dal.executarNonQuery("Update [Medico_especialidade] set nome=@nome, morada=@morada, telefone=@telefone, morada_centro=@morada_centro, telefone_centro=@telefone_centro", sqlParams);
            }
        }

        public class Alarmes
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Alarmes", null);
            }

            static public DataTable LoadOrdenadoHora(string hora)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@hora", hora)
                };
                return dal.executarReader("select * from Alarmes where hora>@hora order by hora asc", sqlParams);
            }

            static public DataTable LoadHoraAtual(string hora)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@hora", hora)
                };
                return dal.executarReader("select * from Alarmes where hora=@hora", sqlParams);
            }

            static public int insertAlarme(int id_toque, string descricao, int tipo_alarme, string hora, bool ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_toque", id_toque),
                new SqlParameter("@descricao", descricao),
                new SqlParameter("@tipo_alarme", tipo_alarme),
                new SqlParameter("@hora", hora),
                new SqlParameter("@ativo", ativo)
           };
                return dal.executarNonQuery("INSERT into [Alarmes] (id_toque,descricao,tipo_alarme,hora,ativo) VALUES(@id_toque,@descricao,@tipo_alarme,@hora,@ativo)", sqlParams);
            }

            static public int insertAlarmeSemanais(int id_alarme, string dia_s)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id_alarme),
                new SqlParameter("@dia_s", dia_s)
        
           };
                return dal.executarNonQuery("INSERT into [Alarmes_Semanais] (id,dia_s) VALUES(@id,@dia_s)", sqlParams);
            }

            static public int insertAlarmeDiario(int id_alarme)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id_alarme)
        
           };
                return dal.executarNonQuery("INSERT into [Alarmes_diario] (id) VALUES(@id)", sqlParams);
            }

            static public int insertAlarmePontuais(int id_alarme, DateTime data)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id_alarme),
                new SqlParameter("@data", data)
        
           };
                return dal.executarNonQuery("INSERT into [Alarmes_pontuais] (id,data) VALUES(@id,@data)", sqlParams);
            }

            static public object queryUltimoId()
            {
                DAL dal = new DAL();

                return dal.executarScalar("Select Max(id) From Alarmes", null);
            }

            static public DataTable queryAlarme(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from alarmes where id=@id", sqlParams);
            }

            static public DataTable queryAlarmeSemanais(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from alarmes_semanais where id=@id", sqlParams);
            }

            static public DataTable queryAlarmePontuais(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from alarmes_pontuais where id=@id", sqlParams);
            }

            static public DataTable queryAlarmeMensais(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from alarmes_mensais where id=@id", sqlParams);
            }

            static public int insertAlarmeMensais(int id_alarme, int dia)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id_alarme),
                new SqlParameter("@dia", dia)
        
           };
                return dal.executarNonQuery("INSERT into [Alarmes_Mensais] (id,dia) VALUES(@id,@dia)", sqlParams);
            }


        }

        public class Toques
        {
            static public DataTable queryToque(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from Toque where id=@id", sqlParams);
            }
        }

        public class Galeria
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Galeria", null);
            }

            static public DataTable LoadGaleriaDefault()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Galeria_default", null);
            }

            static public int insertGaleria(byte[] imagem, string nome, string grau_paresteco)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@imagem", imagem),
                new SqlParameter("@nome", nome),
                new SqlParameter("@grau_parentesco", grau_paresteco)
        
           };
                return dal.executarNonQuery("INSERT into [Galeria] (imagem,nome,grau_parentesco) VALUES(@imagem,@nome,@grau_parentesco)", sqlParams);
            }

            static public DataTable queryGaleria(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from Galeria where id=@id", sqlParams);
            }
        }

        public class Jogo_GaleriaFam
        {
            static public DataTable queryFoto(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@id", id),
                };
                return dal.executarReader("select * from Jogo_fotoFam where Id=@Id", sqlParams);
            }

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Jogo_fotoFam", null);
            }

            static public DataTable queryNomes(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@id", id),
                };
                return dal.executarReader("select * from Lista_nomes where Id=@Id", sqlParams);
            }
        }
    }
}