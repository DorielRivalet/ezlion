import os

def remove_duplicate_lines(input_file, output_file):
    lines_seen = set()  # Set to store unique lines
    output_lines = []

    with open(input_file, 'r', encoding="utf-8") as file:
        for line in file:
            line = line.strip()  # Remove leading/trailing whitespace
            if line == '' or line not in lines_seen:
                output_lines.append(line)
                lines_seen.add(line)

    with open(output_file, 'w', encoding='utf-8') as file:
        file.write('\n'.join(output_lines))

# Get the paths to input and output folders
input_folder = 'input'
output_folder = 'input\\unique'

# Create the output folder if it doesn't exist
os.makedirs(output_folder, exist_ok=True)

# Process each input file in the input folder
for filename in os.listdir(input_folder):
    if filename.endswith('.txt'):
        input_file = os.path.join(input_folder, filename)
        output_file = os.path.join(output_folder, f'{os.path.splitext(filename)[0]}-unique.txt')
        remove_duplicate_lines(input_file, output_file)
