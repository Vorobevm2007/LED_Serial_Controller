const int lampPinBlue = 8; // Пин, к которому подключена лампочка/светодиод
const int lampPinRed = 12;
String inputString = "";     // Строка для хранения входящей команды
boolean stringComplete = false; // Флаг, указывающий, что команда получена полностью

void setup() {
  // Настраиваем пин на выход
  pinMode(lampPinRed, OUTPUT);
  pinMode(lampPinBlue, OUTPUT);
  
  // Запускаем последовательный порт на скорости 9600 бод
  // Это стандартная скорость для Arduino
  Serial.begin(9600);
}

void loop() {
  // Проверяем, пришли ли новые данные в порт
  while (Serial.available() > 0) {
    char inChar = (char)Serial.read(); // Читаем один символ
    inputString += inChar;             // Добавляем его к строке
    
    // Если символ - это конец строки (Enter)
    if (inChar == '\n') {
      stringComplete = true; // Устанавливаем флаг, что строка готова к обработке
    }
  }
  
  // Если строка готова, обрабатываем её
  if (stringComplete) {
    // Убираем лишние пробелы и символы перевода строки
    inputString.trim();
    
    // Сравниваем полученную команду с ожидаемыми
    if (inputString == "ONRED") {
      digitalWrite(lampPinRed, HIGH); // Включаем лампочку
    } 
    else if (inputString == "OFFRED") {
      digitalWrite(lampPinRed, LOW);  // Выключаем лампочку
    }
    else if (inputString == "ONBLUE") {
      digitalWrite(lampPinBlue, HIGH); // Включаем лампочку
    } 
    else if (inputString == "OFFBLUE") {
      digitalWrite(lampPinBlue , LOW);  // Выключаем лампочку
    }
    
    // Очищаем строку и сбрасываем флаг для приёма следующей команды
    inputString = "";
    stringComplete = false;
  }
}