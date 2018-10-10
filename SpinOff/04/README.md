1. Доработай свой графический редактор 
   - Добавь возможность загрузить картинку. При этом, все что есть на холсте удаляется
   - При закрытии приложения должен появляться диалог, следует ли сохранить рисунок (если что-то было нарисовано. Если лист чистый, то и диалог не отображается)
2. Доделай крестики-нолики [из прошлого дз](https://github.com/CSharpLords/homework-maxcore25/tree/master/SpinOff/03)
3. Напиши текстовый редактор маркдауна 
   - Редактор состоит из двух панелей: исходный текст (доступен для редактирования) и отформатированный (панель предосмотра). [Пример](https://dillinger.io)
   - Для обработки текста понадобится активное использование методов класса `string` ([описание класса](https://docs.microsoft.com/ru-ru/dotnet/api/system.string?view=netframework-4.7.2#string-operations-by-category), примеры [анализа](https://docs.microsoft.com/ru-ru/dotnet/csharp/how-to/parse-strings-using-split), [поиска](https://docs.microsoft.com/ru-ru/dotnet/csharp/how-to/search-strings)), а также, возможно, [регулярные выражения](https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/regular-expressions) 
   - Об основах формата можно узнать на википедии. Более подробная спецификация маркдауна [находится здесь](https://commonmark.org)
   - Для вывода превью можно, к примеру, использовать [RichTextBox](https://docs.microsoft.com/ru-ru/dotnet/framework/wpf/controls/richtextbox-overview) или [FormattedText](https://docs.microsoft.com/ru-ru/dotnet/framework/wpf/advanced/drawing-formatted-text)
   - Можно доработать синтаксис согласно своим желаниям, а не полностью следовать стандарту маркдауна
