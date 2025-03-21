# Система оренди квартир

## 1. Назва застосунку
EasyFlat – зручна онлайн-платформа для пошуку та бронювання квартир.

## 2. Мета
Забезпечити зручний та ефективний сервіс для пошуку, оренди та управління квартирами. Платформа допомагає орендодавцям знаходити орендарів, а користувачам – швидко знаходити житло відповідно до своїх потреб.

## 3. Користувачі та їх можливості
Орендодавець (Власник квартири)
- Реєстрація та авторизація.
- Додавання оголошень про оренду квартир.
- Редагування та видалення власних оголошень.
- Перегляд заявок від потенційних орендарів.
- Спілкування з орендарями.

Орендар (Користувач, який шукає квартиру)
- Реєстрація та авторизація.
- Перегляд списку доступних квартир.
- Фільтрація за ціною, місцем розташування, площею, кількістю кімнат.
- Надсилання заявок на оренду.
- Спілкування з власниками квартир.

Адміністратор
- Управління користувачами (блокування, видалення, редагування).
- Модерація оголошень (видалення недостовірних або некоректних записів).

## 4. Основні сутності  (основні об'єкти, якими оперує застосунок, та їх поля)

#### 1. Користувач (User)
-  ID
-  Ім'я
- Email
- Номер телефону
- Тип користувача (Орендар/Орендодавець/Адміністратор)

#### 2. Оголошення (Listing)
- ID
- Назва
- Опис
- Локація
- Ціна оренди
- Кількість кімнат
- Площа
- Фото
- ID власника
- Дата публікації

#### 3. Бронювання (Booking) 
- ID
- ID орендаря
- ID оголошення
- Дата початку оренди
- Дата завершення оренди
- Статус (очікує підтвердження/підтверджено/відхилено)

#### 4. Повідомлення (Message)
- ID
- ID відправника
- ID отримувача
- Текст повідомлення
- Дата надсилання

## 5. Можливості застосунку
- Реєстрація та авторизація користувачів. 
- Додавання та редагування оголошень. 
- Надсилання заявок на оренду. 
- Чат між орендодавцем та орендарем. 
- Модерація контенту адміністратором.
- Можливість залишити відгуки.
- Фільтрація квартир за параметрами.

## 6. Вибір технології UI. 
WinForms
