using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace LesAnimales.Models
{
    public class OffreRepository : IOffreRepository
    {
        private IDbConnection connection;

        public OffreRepository(IDbConnection connection)
        {
            this.connection = connection;
        }

        public IEnumerable<Offre> AllOffres => connection.Query<Offre>("SELECT * FROM Offre");

        public Offre GetById(int id) => connection.QueryFirst<Offre>("SELECT * FROM Offre WHERE Id=@Id", new { Id = id });

        public void Save(Offre offre)
        {
            string sql;

            if (offre.Id.HasValue)
            {
                sql = "UPDATE Offre SET Titre=@Titre, Description=@Description, Photo=@Photo, Prix=@Prix, UserId=@UserId WHERE Id=@Id";
            }
            else
            {
                sql = "INSERT INTO Offre (Titre, Description, Photo, Prix) VALUES (@Titre, @Description, @Photo, @Prix)";
            }
            connection.Execute(sql, offre);
        }
    }
}
