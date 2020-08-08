using BLL.DomainModels;
using Xunit;
using DAL;
using NSubstitute;
using Service;

namespace BLL.Tests
{
    public class BLLSkillMethodTests
    {
        [Fact]
        public void PostSkill_ReturnedObjectShouldHaveSameValues()
        {
            //Arrange            
            var ContactId = 1;

            var skillModelDal = new Skills
            {
                SkillId = 1,
                Description = "Test Description"
            };

            var skillModelDomain = new SkillDomainModel()
            {
                SkillId = ContactId,
                Description = "returned and mapped object"
            };

            var dalMock = Substitute.For<IPostSkillDAL>();
            dalMock.postSkillDAL(ContactId, skillModelDal).ReturnsForAnyArgs(skillModelDal);

            var sut = new PostSkillBLL(dalMock);

            //Act
            var result = sut.postSkillBLL(ContactId, skillModelDomain);

            //Assert
            Assert.Equal(1, result.SkillId);
            Assert.Equal("Test Description", result.Description);
        }


        [Fact]
        public void GetSkillById_ReturnedObjectShouldHaveSameValues()
        {
            //Arrange            
            var ContactId = 1;

            var skillModelDal = new Skills
            {
                SkillId = ContactId,
                Description = "Test Description"
            };

            var skillModelDomain = new SkillDomainModel()
            {
                SkillId = ContactId,
                Description = "returned and mapped object"
            };

            var dalMock = Substitute.For<IGetSkillsDAL>();
            dalMock.GetSkillByContactId(ContactId).ReturnsForAnyArgs(skillModelDal); // ReturnsForAnyArgs(skillModelDal);

            var sut = new GetSkillsBLL(dalMock);

            //Act
            var result = sut.getSkillsByIdBLL(ContactId);

            //Assert
            Assert.Equal(ContactId, result.SkillId);
            Assert.Equal("Test Description", result.Description);
        }

        [Fact]
        public void GetSkills_ShouldReturnListOfDomainSkillObject()
        {
            //Arrange            
            var ContactId = 1;

            var skillModelDal = new Skills
            {
                SkillId = ContactId,
                Description = "Test Description"
            };

            var skillModelDomain = new SkillDomainModel()
            {
                SkillId = ContactId,
                Description = "returned and mapped object"
            };

            var dalMock = Substitute.For<IGetSkillsDAL>();
            dalMock.GetSkillByContactId(1).ReturnsForAnyArgs(skillModelDal); // ReturnsForAnyArgs(skillModelDal);

            var sut = new GetSkillsBLL(dalMock);

            //Act
            var result = sut.getSkillsByIdBLL(ContactId);

            //Assert
            Assert.Equal(ContactId, result.SkillId);
            Assert.Equal("Test Description", result.Description);
        }
    }
}
