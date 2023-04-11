from flask import Flask, render_template, jsonify

app = Flask(__name__,static_folder="templates")

@app.route("/", methods=["GET", "POST"])
def main_page():
    return render_template("index.html")

if __name__ == "__main__":
    app.run(debug=True , port=8888)