namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ',' DONE
            var cells = line.Split(','); //KW this line is taking the method Split and using it on a line(line is a string) to create an array of strings

            // If your array.Length is less than 3, something went wrong

            if (cells.Length < 3) //KW the if statement is checking if the statement is less than 3, then we would have to throw an error
            {
                logger.LogError("too few elements");
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement DONE //KW we returned null because the program didn't work / ITrackable is nullable
            }

            var latitude = double.Parse (cells[0]); //double.Parse is changing the string from cells and changing it to a double (usually for long numbers with decimals)
            var longitude = double.Parse(cells[1]);
            var name = cells[2]; //on this var we are getting the name, and the last cells, but we are NOT changing the type
            //we wrote the var above to tell the program what we wanted to do from the comments below
            // grab the latitude from your array at index 0
            // grab the longitude from your array at index 1
            // grab the name from your array at index 2 DONE

            // Your going to need to parse your string as a `double`DONE (line 27, 28)
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class DONE
            // that conforms to ITrackable DONE 
            var tacoBell = new TacoBell();
            tacoBell.Name = name;

            //below I declared location with a variable and then I set the properties of location
            var Location = new Point();  //Point is used to define Latitude and Longitude or Coordinates
            Location.Latitude = latitude; //when using dot notation I'm taking the properties from what I comformed
            Location.Longitude = longitude;
            tacoBell.Location = Location;
            

            // Then, you'll need an instance of the TacoBell class DONE
            // With the name and point set correctly DONE

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell; //after setting it all up, we want it to return
        }
    }
}