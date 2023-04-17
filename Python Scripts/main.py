import os
import parserL
import preprocess
from transformers import GPT3Tokenizer, GPT3ForCausalLM, Trainer, TrainingArguments

def main():
    # Get the path to the PDF file
    pdf_path = input("Enter the path to the PDF file: ")

    # Parse the PDF file
    raw_text = parserL.extract_text(pdf_path)

    # Preprocess the text
    preprocessed_text = preprocess.preprocess_text(raw_text)

    # Print the preprocessed text
    print(preprocessed_text)

    # Save the preprocessed text to a file
    script_dir = os.path.dirname(__file__)
    output_file_path = os.path.join(script_dir, 'preprocessed_text.txt')
    with open(output_file_path, 'w', encoding='utf-8') as f:
        f.write(preprocessed_text)

    # Load the GPT3Tokenizer
    tokenizer = GPT3Tokenizer.from_pretrained('gpt3')

    # Tokenize the preprocessed text
    tokenized_text = tokenizer(preprocessed_text, return_tensors='pt').input_ids

    # Load the GPT3ForCausalLM model
    model = GPT3ForCausalLM.from_pretrained('gpt3')

    # Define the training arguments
    training_args = TrainingArguments(
        output_dir='./results',
        overwrite_output_dir=True,
        num_train_epochs=1,
        per_device_train_batch_size=1,
        save_steps=500,
        save_total_limit=2,
        learning_rate=5e-5,
        prediction_loss_only=True,
        logging_steps=500
    )

    # Define the trainer object
    trainer = Trainer(
        model=model,
        args=training_args,
        train_dataset=tokenized_text
    )

    # Fine-tune the model
    trainer.train()

    # Save the fine-tuned model
    script_dir = os.path.dirname(__file__)
    output_model_path = os.path.join(script_dir, 'fine_tuned_model')
    trainer.save_model(output_model_path)

if __name__ == '__main__':
    main()