using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternTest
{
    [TestClass]
    public class PersonRepositoryTest
    {
        public RepositoryPattern.Persistences.Repositories.PersonRepository PersonRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            //インスタンス作成
            PersonRepository = new RepositoryPattern.Persistences.Repositories.PersonRepository();
        }        
        
        [TestMethod]
        public void GetAllTest()
        {

            IEnumerable<RepositoryPattern.Persistences.Entities.Person>
                People = PersonRepository.GetAll();

            List<RepositoryPattern.Persistences.Entities.Person> personList 
                = People.ToList();


            RepositoryPattern.Persistences.Entities.Person person
                = personList.FirstOrDefault();

            Assert.IsNotNull(person);
        }

        [TestMethod]
        public void GetTest()
        {
            string id = "001";
            RepositoryPattern.Persistences.Entities.Person person
                = PersonRepository.Get(id);

            Assert.IsNotNull(person);
        }

        [TestMethod]
        public void AddTest()
        {
            RepositoryPattern.Persistences.Entities.Person newPerson =
                new RepositoryPattern.Persistences.Entities.Person
                {
                    Id = "002",
                    FirstName = "太郎",
                    LastAndMiddleName = "田中"
                };
            PersonRepository.Add(newPerson);

            RepositoryPattern.Persistences.Entities.Person registedPerson
                    = PersonRepository.Get(newPerson.Id);

            Assert.IsNotNull(registedPerson);
        }

        [TestMethod]
        public void UpdateTest()
        {
            RepositoryPattern.Persistences.Entities.Person registedPerson
                = PersonRepository.Get("002");

            registedPerson.FirstName = "花子";
            registedPerson.LastAndMiddleName = "山田";

            PersonRepository.Update(registedPerson);

            RepositoryPattern.Persistences.Entities.Person updatedPerson
                    = PersonRepository.Get(registedPerson.Id);

            Assert.IsTrue(registedPerson.FirstName == updatedPerson.FirstName);
        }

        [TestMethod]
        public void DeleteTest()
        {
            
            RepositoryPattern.Persistences.Entities.Person deletePerson
                    = PersonRepository.Get("002");

            PersonRepository.Delete(deletePerson);

            RepositoryPattern.Persistences.Entities.Person deletedPerson
                    = PersonRepository.Get("002");


            Assert.IsNull(deletedPerson);
        }


    }
}
