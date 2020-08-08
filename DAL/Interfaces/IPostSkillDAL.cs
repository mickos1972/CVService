namespace DAL
{
    public interface IPostSkillDAL
    {
        Skills postSkillDAL(int contactDetailId, Skills source);
    }
}