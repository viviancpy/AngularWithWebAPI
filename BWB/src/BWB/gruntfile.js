module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');

    grunt.initConfig({
        uglify: {
            my_target: {
                files: { 'wwwroot/app.js': ['app/app.js', 'app/**/*.js'] }
            }
        },
        watch: {
            scripts: {
                files: ['app/**/*.js'],
                tasks: ['uglify']
            }
        }
    });
    grunt.registerTask('default', ['uglify', 'watch']);
};