import PyPDF2
import nltk
from nltk.tokenize import word_tokenize
from nltk.corpus import stopwords
from nltk.stem import SnowballStemmer

# Initialize the NLTK stemmer
stemmer = SnowballStemmer("english")

print("Preprocessing Started!")

def preprocess_text(text):
    # Tokenize the text
    tokens = word_tokenize(text)

    # Lowercase the tokens
    tokens = [token.lower() for token in tokens]

    # Remove stop words
    stop_words = set(stopwords.words("english"))
    tokens = [token for token in tokens if token not in stop_words]

    # Stem the tokens
    tokens = [stemmer.stem(token) for token in tokens]

    # Join the stemmed tokens back into a single string
    preprocessed_text = " ".join(tokens)

    return preprocessed_text

def parse_pdf(pdf_path):
    # Open the PDF file in read mode
    with open(pdf_path, "rb") as pdf_file:
        # Create a PDF reader object
        pdf_reader = PyPDF2.PdfFileReader(pdf_file)

        # Get the number of pages in the PDF document
        num_pages = pdf_reader.getNumPages()

        # Loop through each page and extract the text
        text = ""
        for page_num in range(num_pages):
            page = pdf_reader.getPage(page_num)
            text += page.extractText()
        
        print("PP Text: " + preprocessed_text) # Check if the variable is empty

        # Print the extracted text
        print("Extracted text:", text)

        # Preprocess the text
        preprocessed_text = preprocess_text(text)

        return preprocessed_text
    
print("Preprocessing Ended!")