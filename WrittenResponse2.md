# Solo project 2 Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would use my program to get the weather for the future and can also show multiple place's weather at the same time.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that my program shows the weather for today and compare it to other weathers. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. They enter a how many place's weather they want to compare then the program prompts the user to input that number of zip codes, then outputs the weather for the next day for each zip code. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp

    int count = Int32.Parse(input);
    List<string> Zips;
     Zips = new List<string>();
    while (Zips.Count < count)
    {
        Console.WriteLine("Enter a zipcode");
        Zips.Add(Console.ReadLine());
    }
    return Zips;
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
List<string> fcast = forecast(variable);
foreach (string yes in fcast)
{
    Console.WriteLine($"{yes}");
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
}
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {Zips}

### 3b iv.

Describes what the data contained in the list represents in your program

The zip codes that are input by the user are stored in the list {Zips}.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

If these were not saved in a list, I would have to have the same number of variables as zip codes input. At a lower number it would be okay, but as the number of inputs becomes larger, the number of variable would also rise meaning that my program would become overly complex. The list saves them all in one place.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static List<string> getZipCodes(string input)
        {
            if (input == null)
            {
                throw new Exception("Input may not be null.");
            }
            // 1. Ask if the user would want to compare weather
            // 2. Make sure its a number somehow
            // 3. Ask how many places' weather they would like to see
            // 4. Make sure input is integer
            // 5. Ask for x number of zipcodes
            // 6. Save all inputs to a list to use in the weather Api.

            int count = Int32.Parse(input);
            List<string> Zips;
            Zips = new List<string>();
            while (Zips.Count < count)
            {
                Console.WriteLine("Enter a zipcode");
                Zips.Add(Console.ReadLine());
            }
            return Zips;
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
List<string> resultss = getZipCodes(numberr);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a input that is not null, the procedure repeats or loops the part of the program which asks for zip codes the number of time that the user asked for. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Takes in a string. 
2. Converts the string into a integer and saves the integer in a variable named "count".
3. Creates a list named "Zips".
4. A while loop is started which continues until the number of things in "Zips" is equal to "count".
   1. In the loop the program asks for a zip code.
   2. Reads the input and then adds it to the "Zips".
5. Returns the list.

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

```csharp
getZipCodes(null);
```

Second call:

```csharp
getZipCodes(4);
```

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This will test if the input is null by making an if statement true. 

Condition(s) tested by the second call:

This will test if method runs if the input is not null.

### 3d iii.

Result of the first call:

It would result in the the if statement being true and in the program saying "Input may not be null."

Result of the second call:

It will return as valid and continue the program. 