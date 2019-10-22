using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepositoryPattern.Repositories
{
    /// <summary>
    /// DBアクセスし、Personの情報にアクセスするクラス
    /// </summary>
    /// <remarks></remarks>
    public class PersonRepository : Interfaces.IRepository<Entities.Person>
    {
        

        public Entities.Person Get(int id)
        {
            return null;
        }

        public IEnumerable<Entities.Person> GetAll()
        {
            return null;
        }

        public void Add(Entities.Person person)
        {

        }

        public void Update(Entities.Person person)
        {

        }

        public void Delete(Entities.Person person)
        {
            
        }
    }
}
