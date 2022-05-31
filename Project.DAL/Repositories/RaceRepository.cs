using Project.DAL.Entities;
using Project.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Connections;

namespace Project.DAL.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        //ou on met les requête ado
        private Connection _Connection;
        public RaceRepository(Connection connection)
        {
            _Connection = connection;

        }
        public bool Delete(int id)
        {
            Command cmd = new Command("DELETE FROM Race WHERE Id_Race = @Id_Race");
            cmd.AddParameter("Id_Race", id);

            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public IEnumerable<RaceEntity> GetAll()
        {
            Command cmd = new Command("select * from race");

            return _Connection.ExecuteReader(cmd, MapRecordToRace);

        }
        private RaceEntity MapRecordToRace(IDataRecord record)
        {
            return new RaceEntity()
            {
                IdRace = (int)record["Id_Race"],
                Name = (string)record["Name"],
                EnduranceModifier = (int)record["EnduranceModifier"],
                StrengthModifier = (int)record["Strength_Modifier"]
            };
        }

        public RaceEntity GetById(int id)
        {
            Command cmd = new Command("SELECT * FROM Id_Race = @Id_Race");
            cmd.AddParameter("Id_Race", id);
            return _Connection.ExecuteReader(cmd, MapRecordToRace).SingleOrDefault();
        }

        public int Insert(RaceEntity entity)
        {
            Command cmd = new Command("INSERT INTO Race (Name, EnduranceModifier, Strength_Modifier) values (@Name,@Endurance_Modifier,@Strength_Modifier)");
            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Endurance_Modifier", entity.EnduranceModifier);
            cmd.AddParameter("Strength_Modifier", entity.StrengthModifier);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public bool Update(int id, RaceEntity entity)
        {
            command cmd = new command("UPDATE Race " +
                "Set Name=@Name, EnduranceModifier=@Endurance_Modifier, Strength_Modifier=@Strength_Modifier" +
                "where Id_Race=@Id_Race");
            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Endurance_Modifier", entity.EnduranceModifier);
            cmd.AddParameter("Strength_Modifier", entity.StrengthModifier);
            cmd.AddParameter("Id_Race", entity.IdRace);

            return _Connection.ExecuteNonQuery(cmd) == 1;

        }
    }
}
