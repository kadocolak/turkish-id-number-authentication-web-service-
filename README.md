# Turkish identity number authentication web service

## What will the Turkish identity inquiry do for me?

In some cases, real persons are required to be registered in the system. We may request that a fake, bot or a person's second account is not opened.In such cases, we need a value that distinguishes everyone from each other, namely the TR identity number.

The web service in the project works via the link below;

https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx

Write and send the 11-digit TR ID number, full name, full surname and year of birth of the person you want to query (only 4-digit number).

The result will be true or false.

If true, it means a natural person, if false, such a person does not have an official citizenship record.

## Why does it work in POST method?

For security measure. Let's say you have entered the information and you want to open the link in your own browser. Seeing a true - false result immediately will create a vulnerability. Returning the result with the post method ensures that not everyone can see the result.
