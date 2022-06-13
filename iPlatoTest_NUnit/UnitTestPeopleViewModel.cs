using System;
using iPlato_Test.ViewModels;
using iPlato_Test.Models;

namespace iPlatoTest_NUnit
{
    public class Tests
    {
        PeopleViewModel viewModel;
        [SetUp]
        public void Setup()
        {
            viewModel = new PeopleViewModel();
        }

        [Test]
        public void LoadTest()
        {
            int count = viewModel.People.Count;
            Assert.IsTrue(count == 3);
            Assert.Pass();
        }
        [Test]
        public void AddTest()
        {
            Person person = new Person();
            person.PersonId = 4;
            person.Name = "Arvind";
            person.DateOfBirth = "21-12-1987";
            person.Name = "IT";
            viewModel.People.Add(person);

            Assert.IsTrue(viewModel.People.Contains(person));
            Assert.Pass();
        }
        [Test]
        public void DeleteTest()
        {
            Person person = new Person();
            person.PersonId = 4;
            person.Name = "Arvind";
            person.DateOfBirth = "21-12-1987";
            person.Name = "IT";
            viewModel.People.Add(person);
            viewModel.People.Remove(person);
            Assert.IsTrue(!viewModel.People.Contains(person));
            Assert.Pass();
        }
        [Test]
        public void UpdateTest()
        {
            Person person = new Person();
            person.PersonId = 4;
            person.Name = "Arvind";
            person.DateOfBirth = "21-12-1987";
            person.Name = "IT";
            viewModel.People.Add(person);
            int index = viewModel.People.IndexOf(person);

            person.Name = "Kumar";
            viewModel.People[index] = person;

            Assert.IsTrue(viewModel.People.FirstOrDefault(x=>x.PersonId==4)?.Name=="Kumar");
            
            Assert.Pass();
        }

    }
}
