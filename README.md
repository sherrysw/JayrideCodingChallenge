# JayrideCodingChallenge
Jayride - 1st Round Technical Take-Home Challenge for Sherry Wang 

Coding Challenge
The challenge is about building an API with the following requirements, after you finish please upload
the code a public GitHub repository and send us the URL.
Task 1
The API should reply on the resource request to /candidate with the following information
{
"name": “test”,
"phone": “test”
}
Task 2
The API should reply to the resource request /Location that takes the IP and returns the city location that
corresponds to this IP address.
Hint: You can use any free IP/Location API available to do this, e.g. https://ipstack.com/product
Task 3
The API should reply to the resource request /Listings that takes the number of passengers as a
parameter.
The code should call the search endpoint
https://jayridechallengeapi.azurewebsites.net/api/QuoteRequest to get the search data. Utilising the
listings array, filter out listings that don’t support the number of passengers. With the remaining listings,
calculate the total price and return the results sorted by total price
