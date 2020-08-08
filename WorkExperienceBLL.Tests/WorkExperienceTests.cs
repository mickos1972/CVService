using System;
using System.Collections.Generic;
using BLL.DomainModels;
using DAL;
using NSubstitute;
using Service;
using Xunit;


namespace WorkExperienceBLL.Tests
{
    public class WorkExperienceTests
    {
        [Fact]
        public void GetSkills_ShouldReturnListOfDomainSkillObject()
        {
            //Arrange            
            var ContactId = 1;

            var workexperienceListDal = new List<WorkExperienceDAL>()
            {
                new WorkExperienceDAL()
                {
                    Id = 1,
                    from = DateTime.Today,
                    to = DateTime.Today,
                    duties = "Test",
                    ContactId = ContactId
                },
                new WorkExperienceDAL()
                {
                    Id = 1,
                    from = DateTime.Today,
                    to = DateTime.Today,
                    duties = "Test",
                    ContactId = ContactId
                }
            };

            var workexperienceListBll = new List<WorkExperienceDomainModel>()
            {
                new WorkExperienceDomainModel
                {
                    Id = 1,
                    from = DateTime.Today,
                    to = DateTime.Today,
                    duties = "Test",
                    ContactId = ContactId
                },
                new WorkExperienceDomainModel()
                {
                    Id = 1,
                    from = DateTime.Today,
                    to = DateTime.Today,
                    duties = "Test",
                    ContactId = ContactId
                }
            };

            var dalMock = Substitute.For<IGetWorkExperienceByContactIdDAL>();
            dalMock.getWorkExperienceByContactIdDAL(ContactId).ReturnsForAnyArgs(workexperienceListDal);

            var sut = new GetWorkExperienceByContactIdBLL(dalMock);

            //Act
            var result = sut.getWorkExperienceByContactIdBLL(ContactId);

            //Assert
            Assert.Equal(result.Count, workexperienceListBll.Count);
            Assert.Equal(result[0].ContactId, workexperienceListBll[0].ContactId);
            Assert.Equal(result[0].duties, workexperienceListBll[0].duties);
            Assert.Equal(result[0].from, workexperienceListBll[0].from);
            Assert.Equal(result[0].to, workexperienceListBll[0].to);

            Assert.Equal(result[1].ContactId, workexperienceListBll[1].ContactId);
            Assert.Equal(result[1].duties, workexperienceListBll[1].duties);
            Assert.Equal(result[1].from, workexperienceListBll[1].from);
            Assert.Equal(result[1].to, workexperienceListBll[1].to);
        }
    }
}
