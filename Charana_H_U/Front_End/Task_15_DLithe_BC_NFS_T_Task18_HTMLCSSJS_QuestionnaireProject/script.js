const quizQuestions = [
    {
        question: "Which language runs in a web browser?",
        option1: "Java",
        option2: "C",
        option3: "Python",
        option4: "javascript",
        correct: "option4",
    },
    {
        question: "What does CSS stand for?",
        option1: "Central Style Sheets",
        option2: "Cascading Style Sheets",
        option3: "Cascading Simple Sheets",
        option4: "Cars SUVs Sailboats",
        correct: "option2",
    },
    {
        question: "What does HTML stand for?",
        option1: "Hypertext Markup Language",
        option2: "Hypertext Markdown Language",
        option3: "Hyperloop Machine Language",
        option4: "Helicopters Terminals Motorboats Lamborginis",
        correct: "option1",
    },
    {
        question: "What year was JavaScript launched?",
        option1: "1996",
        option2: "1995",
        option3: "1994",
        option4: "none of the above",
        correct: "option2",
    },


];

const quiz = document.getElementById('quiz')

const answerEls = document.querySelectorAll('.answer')

const questionEl = document.getElementById('question')

const option1_text = document.getElementById('option1_text')

const option2_text = document.getElementById('option2_text')

const option3_text = document.getElementById('option3_text')

const option4_text = document.getElementById('option4_text')

const submitBtn = document.getElementById('submit')


//initialize array item index 0
let currentQuiz = 0

//inittially score is 0
let score = 0

loadQuiz()


//load quiz to html
function loadQuiz() {

    deselectAnswers()

    const currentQuizQuestions = quizQuestions[currentQuiz]

    questionEl.innerText = currentQuizQuestions.question
    option1_text.innerText = currentQuizQuestions.option1
    option2_text.innerText = currentQuizQuestions.option2
    option3_text.innerText = currentQuizQuestions.option3
    option4_text.innerText = currentQuizQuestions.option4
}

//deselect answers
function deselectAnswers() {
    answerEls.forEach(answerEl => answerEl.checked = false)
}

function getSelected() {
    let answer
    answerEls.forEach(answerEl => {
        if (answerEl.checked) {
            answer = answerEl.id
        }
    })
    return answer
}

//evaluate the answer
submitBtn.addEventListener('click', () => {
    const answer = getSelected()
    if (answer) {
        if (answer === quizQuestions[currentQuiz].correct) {
            score++
        }

        currentQuiz++

        if (currentQuiz < quizQuestions.length) {
            loadQuiz()
        }
        else {
            quiz.innerHTML = "You answered correctly " + score + ' quesions out of ' + quizQuestions.length + " quesions";
        }
    }
})