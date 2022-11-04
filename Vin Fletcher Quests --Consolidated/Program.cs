// See https://aka.ms/new-console-template for more information

CraftArrow arrow = new(65, CraftArrow.ArrowheadType.steel, CraftArrow.FletchingType.turkey_feathers);
class CraftArrow
{
    private int _length;
    private ArrowheadType _ArrowHeadType;
    private FletchingType _FletchingType;
    public enum ArrowheadType { steel, wood, obsidian }
    public enum FletchingType { plastic, turkey_feathers, goose_feathers }
    public int Length { get; private set; }
    public ArrowheadType GetArrowheadType { get; }
    public FletchingType GetFletchingType { get; }

    public CraftArrow(int length = 60, ArrowheadType arrowHeadType, FletchingType fletchingType)
    {
        _length = length;
        _ArrowHeadType = arrowHeadType;
        _FletchingType = fletchingType;
    }
    public float GetCost()
    {
        float gold = 0;
        switch (this._ArrowHeadType)
        {
            case ArrowheadType.steel:
                gold += 10;
                break;
            case ArrowheadType.wood:
                gold += 3;
                break;
            case ArrowheadType.obsidian:
                gold += 5;
                break;
        }
        switch (this._FletchingType)
        {
            case FletchingType.plastic:
                gold += 10;
                break;
            case FletchingType.turkey_feathers:
                gold += 5;
                break;
            case FletchingType.goose_feathers:
                gold += 3;
                break;
        }
        return (float)(gold + (this._length * 0.05));
    }
}