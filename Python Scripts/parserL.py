
import PyPDF2
import nltk
import preprocess

def extract_text(pdf_path):
    # Download punkt resource
    nltk.download('punkt')
    nltk.download('stopwords')
    # Open the PDF file in read mode
    try:
        with open(pdf_path, "rb") as pdf_file:
            # Create a PDF reader object
            pdf_reader = PyPDF2.PdfReader(pdf_file)

            # Get the number of pages in the PDF document
            num_pages = len(pdf_reader.pages)

            # Extract the text from each page
            text = ""
            for page_num in range(num_pages):
                page = pdf_reader.pages[page_num]
                text += page.extract_text()

            return text

    except FileNotFoundError:
        print(f"Error: Could not find file {pdf_path}")
    except PermissionError:
        print(f"Error: Permission denied for file {pdf_path}")