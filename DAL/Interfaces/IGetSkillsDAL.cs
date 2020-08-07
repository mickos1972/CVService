namespace DAL
{
    public interface IGetSkillsDAL
    {
        Skills GetSkillById(int id);
        Skills GetSkillByContactId(int ContactId);
    }
}