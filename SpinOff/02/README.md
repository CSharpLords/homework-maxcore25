1. Ты уже писал программу, генерирующую случайные фразы (задача 4 из [занятия 15](https://github.com/CSharpLords/lessons-maxcore25/tree/master/15.%20arrays)). Пришло время улучшить ее и сделать для нее графический интерфейс!

   Собери интерфейс по примеру на скриншоте

   - Раньше слова хранились в трех массивах, теперь сделай, чтобы они хранились в трех списках (`ListBox`, заполняется через свойство `Items`: в диалоговом окне добавляй элементы `ListBoxItem` с нужным словом)
   - По клику кнопки `Сгенерировать` выводи случайную фразу
   - Узнать количество элементов списка можно через свойство списка `Items.Count`
   - Получить текст из пункта №2 списка с именем `listBox` можно так: `((ListBoxItem)listBox.Items[1]).Content`. Здесь мы выбираем пункт с индексом 1, приводим его к типу `ListBoxItem` и считываем его свойство `Content`
   - При добавлении или удалении новых слов в лист боксах программа не должна ломаться

   ![](https://lh3.googleusercontent.com/YbB2xkGfaaB97tfwoLS7Ah8wsbHeBbE4Zar6efQf__uQUMFvTT4M4O3BiFyfSwWsd2FbmYwHXdWUaq3gzB9mLfAIQapMJT9VqMTY9IBbMCs4Vs7Yk-W8tiYMtHod14-qzVzEMAOTuUviPHpAFw)

2. Добавь возможность пользовательского изменения списка: добавь по одной кнопке `Добавить` и по одному `TextBox` для каждого списка

   - Добавить новый пункт в список можно через метод `Items.Add("какой-то текст")`
   - Попробуй самостоятельно разобраться и реализовать удаление слов из списков (например, при выборе слова мышью)

   ![](https://lh4.googleusercontent.com/JPPwN35MYQY9-25wfRYYP-Vurbw4Zes8aXlyffF3yE2GVGfSOw5tjsH7FGkYnzzA1cLxJrDfcfebRUnnakFUPJ7BN5QyLPTmnA8mzGQzSchaAr3rmFRhScW6-qIQXp5srBa0A5OWN6gIa9Y8qg)
