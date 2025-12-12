class countries:
    def __init__(self, name, capital, currency, language):
        self.name = name
        self.capital = capital
        self.currency = currency
        self.language = language

    def show_info(self):
        print(f"Name: {self.name} Capital: {self.capital} Currency: {self.currency} Language: {self.language}")

country1 = countries("United Kingdom", "London", "Pound", "English")
country2 = countries("Poland", "Warsaw", "Zloty", "Polish")
country3 = countries("Turkiye", "Ankara", "Lira", "Turkish")

country1.show_info()
country2.show_info()
country3.show_info()
