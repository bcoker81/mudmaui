namespace AspNetCoreBlazorStateManagement.Data;

public class DropdownOptions
{
    public static string[] highwayClassSelection = {
        "[A] INTERSTATE HIGHWAY","[B] U.S. HIGHWAY","[C] STATE NUMBERED","[D] STATE LETTERED","[E] ALTERNATE ROUTE","[F] BYPASS ROUTE"
    };

    public static string[] countrySelection = {
        "[1] CANADA","[2] MEXICO","[3] UNITED STATES"
    };

    public static string[] stateSelection = {
        "[AK] ALASKA","[AL] ALABAMA","[AR] ARKANSAS","[AZ] ARIZONA","[CA] CALIFORNIA"
    };

    public static string[] countySelection = {
        "[001] ADAIR","[002] ANDREW","[003] ATCHISON","[004] AUDRAIN","[005] BARRY"
    };

    public static string[] addressTypes ={
        "[1] ROADWAY","[2] STREET ADDRESS","[3] RURAL RT / FREE TEXT","[4] WATERWAY"
    };

    public static string[] troops = {
        "Troop A","Troop B","Troop C","Troop D","Troop E","Troop F","Troop G","Troop H","Troop I","GHQ"
    };

    public static string[] occurredWhen = {
        "On","Before"
    };

    public static string[] entityType = {
        "[1] Person", "[2] Business"
    };

    public static string[] agencyNames = {
        "ADAIR CO SO KIRKSVILLE","NORTH MO DRUG TASK FORCE","KIRKSVILLE PD","CITY ATTORNEY-KIRKSVILLE","CIR CRT-MUN DIV-KIRKSVILLE","KIRKSVILLE E-911 JOIN COMM CENTER","CO PROS ATTORNEY-KIRKSVILLE","CO PROBATION DEPT-KIRKSVILLE"
    };

    public static async Task<IEnumerable<string>> SearchEntityType(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return entityType.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    public static async Task<IEnumerable<string>> SearchAddressTypes(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return DropdownOptions.addressTypes.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    public static async Task<IEnumerable<string>> SearchTroops(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return DropdownOptions.troops.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    public static async Task<IEnumerable<string>> SearchOccurredOn(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return DropdownOptions.occurredWhen.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    public static async Task<IEnumerable<string>> SearchCountySelection(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return DropdownOptions.countySelection.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    public static async Task<IEnumerable<string>> SearchHighwayClassSelection(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return DropdownOptions.highwayClassSelection.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    public static async Task<IEnumerable<string>> SearchCountrySelection(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return DropdownOptions.countrySelection.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    public static async Task<IEnumerable<string>> SearchStateSelection(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return DropdownOptions.stateSelection.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }
}
