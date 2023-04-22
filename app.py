from flask import Flask, render_template, jsonify

app = Flask(__name__,static_folder="templates")

@app.route("/", methods=["GET", "POST"])
def main_page():
    return render_template("index.html")

@app.route("/SphereMove", methods=["POST"])
def TempDateToUnity():
    flaskspeed = 10
    res = {"count": flaskspeed}
    return jsonify(res)

if __name__ == "__main__":
    app.run(debug=True , port=8888)