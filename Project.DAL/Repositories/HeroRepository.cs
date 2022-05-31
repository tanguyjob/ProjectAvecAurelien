using Project.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories
{
   public class HeroRepository: IHeroRepository
    {
        private Connection _Connection;
        public HeroRepository(Connection connection)
        {
            _Connection = connection;

        }
        public bool Delete(int id)
        {
            Command cmd = new Command("DELETE FROM Hero WHERE Id_Hero = @Id_Hero");
            cmd.AddParameter("Id_Hero", id);

            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public IEnumerable<HeroEntity> GetAll()
        {
            Command cmd = new Command("select * from Hero");

            return _Connection.ExecuteReader(cmd, MapRecordToHero);

        }
        private HeroEntity MapRecordToHero(IDataRecord record)
        {
            return new HeroEntity()
            {
                IdHero = (int)record["Id_Hero"],
                Name = (string)record["Name"],
                Endurance = (int)record["Endurance"],
                Strength = (int)record["Strength"],
                IdRace = (int)record["Id_Race"]
            };
        }

        public HeroEntity GetById(int id)
        {
            Command cmd = new Command("SELECT * FROM Id_Hero = @Id_Hero");
            cmd.AddParameter("Id_Hero", id);
            return _Connection.ExecuteReader(cmd, MapRecordToHero).SingleOrDefault();
        }

        public int Insert(HeroEntity entity)
        {
            Command cmd = new Command("INSERT INTO Hero (Name, Endurance, Strength, IdRace) values (@Name,@Endurance,@Strength,@IdRace)");
            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Endurance", entity.Endurance);
            cmd.AddParameter("Strength", entity.Strength);
            cmd.AddParameter("IdRace", entity.IdRace);
    

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public bool Update(int id, HeroEntity entity)
        {
            command cmd = new command("UPDATE Hero " +
                "Set Name=@Name, Endurance=@Endurance, Strength=@Strength, Id_Race=@IdRace" +
                "where Id_Hero=@Id_Hero");
            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Endurance_Modifier", entity.EnduranceModifier);
            cmd.AddParameter("Strength_Modifier", entity.StrengthModifier);
            cmd.AddParameter("IdRace", entity.IdRace);
            cmd.AddParameter("Id_Hero", entity.IdHero);

            return _Connection.ExecuteNonQuery(cmd) == 1;

        }

    }
}
