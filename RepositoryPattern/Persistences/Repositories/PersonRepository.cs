using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;


namespace RepositoryPattern.Persistences.Repositories
{
    /// <summary>
    /// DBアクセスし、Personの情報へアクセスするクラス
    /// </summary>
    /// <remarks></remarks>
    public class PersonRepository : Interfaces.IRepository<Entities.Person>
    {
        /// <summary>
        /// コンテキストクラス
        /// </summary>
        private DbContext _dbContext;
        
        public PersonRepository()
        {
            this._dbContext = new SampleDbContext();
        }

        public Entities.Person Get(string id)
        {
            return this._dbContext.Set<Entities.Person>().Find(id);
        }

        public IEnumerable<Entities.Person> GetAll()
        {
            return this._dbContext.Set<Entities.Person>().AsEnumerable();
        }

        /// <summary>
        /// 追加処理
        /// </summary>
        /// <param name="person">追加データ</param>
        public void Add(Entities.Person person)
        {
            this._dbContext.Set<Entities.Person>().Add(person);
            this._dbContext.SaveChanges();
        }
        /// <summary>
        /// 更新処理
        /// </summary>
        /// <param name="person">更新対象</param>
        public void Update(Entities.Person person)
        {
            this._dbContext.SaveChanges();
        }

        /// <summary>
        /// 削除処理
        /// </summary>
        /// <param name="person">削除対象</param>
        public void Delete(Entities.Person person)
        {
            this._dbContext.Set<Entities.Person>().Remove(person);
            this._dbContext.SaveChanges();
        }
    }
}
