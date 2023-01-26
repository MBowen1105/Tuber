namespace Tuber.Application.Common.Interfaces;
public interface IInstitutionDeletionService
{
    ServiceResult<int> Delete(Guid institutionId);
}
