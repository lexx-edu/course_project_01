using System.Text.RegularExpressions;

void PrintArray(String[] array){
    Console.WriteLine();
    string result;
    for (int i=0; i<array.GetLength(0); i++){
            result = array[i];
            Console.Write($"{result} ");
    }
    Console.WriteLine();
}

String[] select_strings(String[] input_array){
    String[] output_array = new String[0];
    int counter = output_array.Count();
    
    foreach (string i in input_array){
        if (i.Length <= 3) {
            counter += 1;
            Array.Resize(ref output_array, counter);
            output_array[counter-1] = i;
        }
    }
    return output_array;
}


String random_word(){
    int chars_qty = new Random().Next(2, 6);
    string str = "";

    for (int i=0; i<chars_qty; i++){
        int symbol = new Random().Next(65, 91);
        str += Convert.ToString((char) symbol);
    }
    return str;
}


String[] random_strings_array(){
    int words_qty = new Random().Next(2, 10);
    String[] words_array = new String[words_qty];

    for (int i = 0; i<words_qty; i++){
        words_array[i] = random_word();
    }
    return words_array;
}


String[] string_to_array(string str){
    str = str.Replace(",", " ");
    String[] array = Regex.Split(str, " {1,6}");
    return array;
}


String[] request_console(){
    String[] output_array;

    Console.Write("\nВведите отдельные слова через пробел или запятую: ");
    string words = Console.ReadLine() ?? "";

    if (words=="") output_array = random_strings_array();
    else output_array = string_to_array(words);

    return select_strings(output_array);
}


String[] run_process(String[] input_array){
    String[] output_array;

    if (input_array.Length==0) output_array = request_console();
    else output_array = select_strings(input_array);
    
    return output_array;
}

String[] array = Array.Empty<string>();
//String[] array = {"сто", "окно", "кот", "сова"};

PrintArray(run_process(array));
