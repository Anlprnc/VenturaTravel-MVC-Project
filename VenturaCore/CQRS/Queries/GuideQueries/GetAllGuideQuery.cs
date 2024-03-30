using MediatR;
using VenturaCore.CQRS.Results.GuideResults;

namespace VenturaCore.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {

    }
}