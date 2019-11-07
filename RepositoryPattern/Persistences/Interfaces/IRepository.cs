using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Persistences.Interfaces
{
    /// <summary>
    /// データのアクセス処理を抽象化するためのインターフェース
    /// </summary>
    public interface IRepository<T>
    {
        /// <summary>
        /// 指定IDを持つオブジェクト取得
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(string id);

        /// <summary>
        /// 全データ取得
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 指定データの追加処理
        /// </summary>
        /// <param name="item">追加対象オブジェクト</param>
        void Add(T item);

        /// <summary>
        /// 指定データの更新処理
        /// </summary>
        /// <param name="item">更新対象オブジェクト</param>
        void Update(T item);

        /// <summary>
        /// 指定データの削除処理
        /// </summary>
        /// <param name="item">削対象オブジェクト</param>
        void Delete(T item);
    }
}
