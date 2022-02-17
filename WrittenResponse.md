# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would use my program to get the weather for the future. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that my program shows the weather for today and the next two days. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. They enter a zip code, and then outputs the weather for the next 3 days. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
 List<string> forecast;
            List<string> forecast1;
            forecast = new List<string>();
            forecast1 = new List<string>();
            Weather weather = new WeatherAPI().GetWeather(input);

            string date0 = weather.ForecastData[0]["date"];
            string high0 = weather.ForecastData[0]["maxtemp_f"];
            forecast.Add($"Forecast {date0} High: {high0}");
            forecast1.Add($"Forecast {date0} High: {high0}");

            string date1 = weather.ForecastData[1]["date"];
            string high1 = weather.ForecastData[1]["maxtemp_f"];
            forecast.Add($"Forecast {date1} High: {high1}");

            string date2 = weather.ForecastData[2]["date"];
            string high2 = weather.ForecastData[2]["maxtemp_f"];
            forecast.Add($"Forecast {date2} High: {high2}");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
    foreach(string result in forecast)
        {
            Console.WriteLine(result);
        }
        return;
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {forecast}.

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the weather for today and the next two days. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity by allowing me to be able to add the number of days that my programs displays without having to add more variables and if statements. I could easily expand my program. 

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
public static bool ValidateZipcode(string input)
        {
            // TODO(jcollard 2022-01-27): Add step-by-step human readable algorithm
            // 1. Takes zipToValidate and reads it
            // 2. Makes sure that it is 5 charecters long.
            // 3. Makes sure that it is only numbers. 
            // 4. If all parameters are met, then return the zipcode as valid, if not all the paramaters are met, then return invalid. 
            if (input == null) throw new Exception("Cannot process null string.");
            foreach (char c in input)
            {
                if (char.IsDigit(c) == false)
                {
                    return false;
                }
            }
            return true;
        }

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 if (ValidateZipcode(zipcode1) == true)
 ```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a string to validate, validates it by checking to see if it 5 characters long and all chars are numbers. If valid returns true otherwise returns false. This is what makes sure that the zip code is valid.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Takes zipToValidate and reads it
2. Makes sure that it is 5 characters long.
3. Makes sure that it is only numbers. 
4. If all parameters are met, then return the zip code as valid, if not all the parameters are met, then return invalid. 

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

ValidateZipcode(null)

Second call:

ValidateZipcode(90304)

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This will test if the input is null by making an if statement true. 

Condition(s) tested by the second call:

This test that the method runs when the input is not null. 

### 3d iii.

Result of the first call:

The result is true so it displays "Cannot process null string."

Result of the second call:

It will return as valid and continue the program. 